
export async function getScreenLayout(screenName) {
    try{
        const template = await import(`./templates/${screenName}.html`);
        return template.default;
    } catch(e) {
        return Promise.resolve(null);
    }
}

export function customiseScreenSettings(screenName, settings) {
    try{
        return import(`./settings/${screenName}`).then(builder => {
            return builder.getSettings(settings);
        }).catch(error => {
            return null;
        });
    } catch(e) {
        return Promise.resolve(null);
    }
}