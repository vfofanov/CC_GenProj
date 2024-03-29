using BusinessFramework.Contracts.OData;
using BusinessFramework.Contracts.Utils.Resources;
using Microsoft.OData.Edm;

namespace NorthWind.Contracts.OData
{
    public sealed class EdmModelReader : IEdmModelReader
    {
        private readonly ResourceEdmModelReader _reader;

        /// <summary>
        ///     Initializes a new instance of the <see cref="T:System.Object" /> class.
        /// </summary>
        public EdmModelReader()
        {
            _reader = new ResourceEdmModelReader(new ResourceFileExtractor(".OData."), "EdmModel.xml");
        }

        public IEdmModel ReadModel()
        {
            return _reader.ReadModel();
        }
    }
}