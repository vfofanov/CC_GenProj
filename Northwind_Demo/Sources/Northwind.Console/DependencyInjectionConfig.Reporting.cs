using System.IO;
using System.Linq;
using BusinessFramework.Client.Common.FileHandlers;
using BusinessFramework.Client.Contracts.Services;
using BusinessFramework.Contracts.FileHandlers;
using FutureTechnologies.DI.Contracts;
using ReportingFramework.Central.Aspose.Cells;
using ReportingFramework.Central.Contracts.Document.Engine;
using ReportingFramework.Central.Contracts.Engine;
using ReportingFramework.Central.Contracts.Spreadsheet.Engine;
using ReportingFramework.Central.Interop.Excel;
using ReportingFramework.Central.Interop.Excel.FileHandlers;
using ReportingFramework.Central.Interop.Word;
using ReportingFramework.Central.Interop.Word.FileHandlers;
using ReportingFramework.Client.ReportSystem.ReportAdapters;

namespace Northwind.Console
{
    partial class DependencyInjectionConfig
    {
        public static void ConfigureReporting(IClientContainerRegistrator registrator)
        {
            registrator.Singleton<IFilePrinterSwitcher, FilePrinterSwitcher>();
            registrator.Singleton<IFilePrinter, ExcelFilePrinter>("Excel");
            registrator.Singleton<IFilePrinter, WordFilePrinter>("Word");
            registrator.Singleton<IFilePrinter, FoxitReaderPdfFilePrinter>("FoxitReader");
            //TODO: Fix problems with UnityContainer register named type with parameters
            //,new Parameter("foxitReaderDirectory", GetFoxitReaderDirectory));

            registrator.Singleton<IFilePreviewSwitcher, FilePreviewSwitcher>();
            registrator.Singleton<IFilePreviewer, ExcelFilePreviewer>("Excel");
            registrator.Singleton<IFilePreviewer, WordFilePreviewer>("Word");

            registrator.Singleton<IEngineSwitcher<SpreadsheetEngine>, EngineSwitcher<SpreadsheetEngine>>(
                new Parameter("defaultEngineName", AsposeSpreadsheetEngine.Name),
                new Parameter("factories", GetSpreadsheetEngineFactories));
            registrator.Singleton<IEngineFactory<SpreadsheetEngine>, AsposeSpreadsheetEngineFactory>(AsposeSpreadsheetEngine.Name);
            registrator.Singleton<IEngineFactory<SpreadsheetEngine>, AutomationSpreadsheetEngineFactory>(AutomationSpreadsheetEngine.Name);

            registrator.Singleton<IEngineSwitcher<DocumentEngine>, EngineSwitcher<DocumentEngine>>(
                new Parameter("defaultEngineName", AutomationDocumentEngine.Name),
                new Parameter("factories", GetDocumentEngineFactories));
            registrator.Singleton<IEngineFactory<DocumentEngine>, AutomationDocumentEngineFactory>(AutomationDocumentEngine.Name);

            registrator.Singleton<IReportAdapterFactory, ReportAdapterFactory>();
        }

        private static string GetFoxitReaderDirectory(IScope scope)
        {
            return Path.Combine(scope.Resolve<IEnvironmentService>().ApplicationPath, "Tools");
        }

        private static IEngineFactory<SpreadsheetEngine>[] GetSpreadsheetEngineFactories(IScope scope)
        {
            return scope.ResolveAll<IEngineFactory<SpreadsheetEngine>>().ToArray();
        }

        private static IEngineFactory<DocumentEngine>[] GetDocumentEngineFactories(IScope scope)
        {
            return scope.ResolveAll<IEngineFactory<DocumentEngine>>().ToArray();
        }
    }
}