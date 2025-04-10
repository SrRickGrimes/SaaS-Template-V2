/* tslint:disable */
/* eslint-disable */
// Generated by Microsoft Kiota
// @ts-ignore
import { type DateOnly, type Parsable, type ParseNode, type SerializationWriter } from '@microsoft/kiota-abstractions';

/**
 * Creates a new instance of the appropriate class based on discriminator value
 * @param parseNode The parse node to use to read the discriminator value and create the object
 * @returns {ServerProductsEndPointsCreateProductCreateProductRequest}
 */
// @ts-ignore
export function createServerProductsEndPointsCreateProductCreateProductRequestFromDiscriminatorValue(parseNode: ParseNode | undefined) : ((instance?: Parsable) => Record<string, (node: ParseNode) => void>) {
    return deserializeIntoServerProductsEndPointsCreateProductCreateProductRequest;
}
/**
 * Creates a new instance of the appropriate class based on discriminator value
 * @param parseNode The parse node to use to read the discriminator value and create the object
 * @returns {ServerProductsEndPointsCreateProductCreateProductResponse}
 */
// @ts-ignore
export function createServerProductsEndPointsCreateProductCreateProductResponseFromDiscriminatorValue(parseNode: ParseNode | undefined) : ((instance?: Parsable) => Record<string, (node: ParseNode) => void>) {
    return deserializeIntoServerProductsEndPointsCreateProductCreateProductResponse;
}
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
export function deserializeIntoServerProductsEndPointsCreateProductCreateProductRequest(serverProductsEndPointsCreateProductCreateProductRequest: Partial<ServerProductsEndPointsCreateProductCreateProductRequest> | undefined = {}) : Record<string, (node: ParseNode) => void> {
    return {
        "description": n => { serverProductsEndPointsCreateProductCreateProductRequest.description = n.getStringValue(); },
        "name": n => { serverProductsEndPointsCreateProductCreateProductRequest.name = n.getStringValue(); },
        "price": n => { serverProductsEndPointsCreateProductCreateProductRequest.price = n.getNumberValue(); },
        "stockQuantity": n => { serverProductsEndPointsCreateProductCreateProductRequest.stockQuantity = n.getNumberValue(); },
    }
}
/**
 * The deserialization information for the current model
 * @returns {Record<string, (node: ParseNode) => void>}
 */
// @ts-ignore
export function deserializeIntoServerProductsEndPointsCreateProductCreateProductResponse(serverProductsEndPointsCreateProductCreateProductResponse: Partial<ServerProductsEndPointsCreateProductCreateProductResponse> | undefined = {}) : Record<string, (node: ParseNode) => void> {
    return {
        "createdAt": n => { serverProductsEndPointsCreateProductCreateProductResponse.createdAt = n.getDateValue(); },
        "description": n => { serverProductsEndPointsCreateProductCreateProductResponse.description = n.getStringValue(); },
        "id": n => { serverProductsEndPointsCreateProductCreateProductResponse.id = n.getStringValue(); },
        "name": n => { serverProductsEndPointsCreateProductCreateProductResponse.name = n.getStringValue(); },
        "price": n => { serverProductsEndPointsCreateProductCreateProductResponse.price = n.getNumberValue(); },
        "stockQuantity": n => { serverProductsEndPointsCreateProductCreateProductResponse.stockQuantity = n.getNumberValue(); },
    }
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
export function serializeServerProductsEndPointsCreateProductCreateProductRequest(writer: SerializationWriter, serverProductsEndPointsCreateProductCreateProductRequest: Partial<ServerProductsEndPointsCreateProductCreateProductRequest> | undefined | null = {}) : void {
    if (serverProductsEndPointsCreateProductCreateProductRequest) {
        writer.writeStringValue("description", serverProductsEndPointsCreateProductCreateProductRequest.description);
        writer.writeStringValue("name", serverProductsEndPointsCreateProductCreateProductRequest.name);
        writer.writeNumberValue("price", serverProductsEndPointsCreateProductCreateProductRequest.price);
        writer.writeNumberValue("stockQuantity", serverProductsEndPointsCreateProductCreateProductRequest.stockQuantity);
    }
}
/**
 * Serializes information the current object
 * @param writer Serialization writer to use to serialize this model
 */
// @ts-ignore
export function serializeServerProductsEndPointsCreateProductCreateProductResponse(writer: SerializationWriter, serverProductsEndPointsCreateProductCreateProductResponse: Partial<ServerProductsEndPointsCreateProductCreateProductResponse> | undefined | null = {}) : void {
    if (serverProductsEndPointsCreateProductCreateProductResponse) {
        writer.writeDateValue("createdAt", serverProductsEndPointsCreateProductCreateProductResponse.createdAt);
        writer.writeStringValue("description", serverProductsEndPointsCreateProductCreateProductResponse.description);
        writer.writeStringValue("id", serverProductsEndPointsCreateProductCreateProductResponse.id);
        writer.writeStringValue("name", serverProductsEndPointsCreateProductCreateProductResponse.name);
        writer.writeNumberValue("price", serverProductsEndPointsCreateProductCreateProductResponse.price);
        writer.writeNumberValue("stockQuantity", serverProductsEndPointsCreateProductCreateProductResponse.stockQuantity);
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
export interface ServerProductsEndPointsCreateProductCreateProductRequest extends Parsable {
    /**
     * The description property
     */
    description?: string | null;
    /**
     * The name property
     */
    name?: string | null;
    /**
     * The price property
     */
    price?: number | null;
    /**
     * The stockQuantity property
     */
    stockQuantity?: number | null;
}
export interface ServerProductsEndPointsCreateProductCreateProductResponse extends Parsable {
    /**
     * The createdAt property
     */
    createdAt?: Date | null;
    /**
     * The description property
     */
    description?: string | null;
    /**
     * The id property
     */
    id?: string | null;
    /**
     * The name property
     */
    name?: string | null;
    /**
     * The price property
     */
    price?: number | null;
    /**
     * The stockQuantity property
     */
    stockQuantity?: number | null;
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
