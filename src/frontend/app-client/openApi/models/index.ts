/* tslint:disable */
/* eslint-disable */
// Generated by Microsoft Kiota
// @ts-ignore
import { type DateOnly, type Parsable, type ParseNode, type SerializationWriter } from '@microsoft/kiota-abstractions';

/**
 * Creates a new instance of the appropriate class based on discriminator value
 * @param parseNode The parse node to use to read the discriminator value and create the object
 * @returns {ServerWeatherForecast}
 */
// @ts-ignore
export function createServerWeatherForecastFromDiscriminatorValue(parseNode: ParseNode | undefined) : ((instance?: Parsable) => Record<string, (node: ParseNode) => void>) {
    return deserializeIntoServerWeatherForecast;
}
/**
 * The deserialization information for the current model
 * @returns {Record<string, (node: ParseNode) => void>}
 */
// @ts-ignore
export function deserializeIntoServerWeatherForecast(serverWeatherForecast: Partial<ServerWeatherForecast> | undefined = {}) : Record<string, (node: ParseNode) => void> {
    return {
        "date": n => { serverWeatherForecast.date = n.getDateOnlyValue(); },
        "summary": n => { serverWeatherForecast.summary = n.getStringValue(); },
        "temperatureC": n => { serverWeatherForecast.temperatureC = n.getNumberValue(); },
        "temperatureF": n => { serverWeatherForecast.temperatureF = n.getNumberValue(); },
    }
}
/**
 * Serializes information the current object
 * @param writer Serialization writer to use to serialize this model
 */
// @ts-ignore
export function serializeServerWeatherForecast(writer: SerializationWriter, serverWeatherForecast: Partial<ServerWeatherForecast> | undefined | null = {}) : void {
    if (serverWeatherForecast) {
        writer.writeDateOnlyValue("date", serverWeatherForecast.date);
        writer.writeStringValue("summary", serverWeatherForecast.summary);
        writer.writeNumberValue("temperatureC", serverWeatherForecast.temperatureC);
        writer.writeNumberValue("temperatureF", serverWeatherForecast.temperatureF);
    }
}
export interface ServerWeatherForecast extends Parsable {
    /**
     * The date property
     */
    date?: DateOnly | null;
    /**
     * The summary property
     */
    summary?: string | null;
    /**
     * The temperatureC property
     */
    temperatureC?: number | null;
    /**
     * The temperatureF property
     */
    temperatureF?: number | null;
}
/* tslint:enable */
/* eslint-enable */
