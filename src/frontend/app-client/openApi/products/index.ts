/* tslint:disable */
/* eslint-disable */
// Generated by Microsoft Kiota
// @ts-ignore
import { createServerProductsEndPointsCreateProductCreateProductResponseFromDiscriminatorValue, createServerProductsEndPointsGetProductsGetProductsResponseFromDiscriminatorValue, serializeServerProductsEndPointsCreateProductCreateProductRequest, serializeServerProductsEndPointsCreateProductCreateProductResponse, type ServerProductsEndPointsCreateProductCreateProductRequest, type ServerProductsEndPointsCreateProductCreateProductResponse, type ServerProductsEndPointsGetProductsGetProductsResponse } from '../models/index.js';
// @ts-ignore
import { type BaseRequestBuilder, type Parsable, type ParsableFactory, type RequestConfiguration, type RequestInformation, type RequestsMetadata } from '@microsoft/kiota-abstractions';

/**
 * Builds and executes requests for operations under /products
 */
export interface ProductsRequestBuilder extends BaseRequestBuilder<ProductsRequestBuilder> {
    /**
     * @param requestConfiguration Configuration for the request such as headers, query parameters, and middleware options.
     * @returns {Promise<ServerProductsEndPointsGetProductsGetProductsResponse>}
     */
     get(requestConfiguration?: RequestConfiguration<ProductsRequestBuilderGetQueryParameters> | undefined) : Promise<ServerProductsEndPointsGetProductsGetProductsResponse | undefined>;
    /**
     * @param body The request body
     * @param requestConfiguration Configuration for the request such as headers, query parameters, and middleware options.
     * @returns {Promise<ServerProductsEndPointsCreateProductCreateProductResponse>}
     */
     post(body: ServerProductsEndPointsCreateProductCreateProductRequest, requestConfiguration?: RequestConfiguration<object> | undefined) : Promise<ServerProductsEndPointsCreateProductCreateProductResponse | undefined>;
    /**
     * @param requestConfiguration Configuration for the request such as headers, query parameters, and middleware options.
     * @returns {RequestInformation}
     */
     toGetRequestInformation(requestConfiguration?: RequestConfiguration<ProductsRequestBuilderGetQueryParameters> | undefined) : RequestInformation;
    /**
     * @param body The request body
     * @param requestConfiguration Configuration for the request such as headers, query parameters, and middleware options.
     * @returns {RequestInformation}
     */
     toPostRequestInformation(body: ServerProductsEndPointsCreateProductCreateProductRequest, requestConfiguration?: RequestConfiguration<object> | undefined) : RequestInformation;
}
export interface ProductsRequestBuilderGetQueryParameters {
    includeInactive?: boolean;
}
/**
 * Uri template for the request builder.
 */
export const ProductsRequestBuilderUriTemplate = "{+baseurl}/products?includeInactive={includeInactive}";
/**
 * Metadata for all the requests in the request builder.
 */
export const ProductsRequestBuilderRequestsMetadata: RequestsMetadata = {
    get: {
        uriTemplate: ProductsRequestBuilderUriTemplate,
        responseBodyContentType: "application/json",
        adapterMethodName: "send",
        responseBodyFactory:  createServerProductsEndPointsGetProductsGetProductsResponseFromDiscriminatorValue,
    },
    post: {
        uriTemplate: ProductsRequestBuilderUriTemplate,
        responseBodyContentType: "application/json",
        adapterMethodName: "send",
        responseBodyFactory:  createServerProductsEndPointsCreateProductCreateProductResponseFromDiscriminatorValue,
        requestBodyContentType: "application/json",
        requestBodySerializer: serializeServerProductsEndPointsCreateProductCreateProductRequest,
        requestInformationContentSetMethod: "setContentFromParsable",
    },
};
/* tslint:enable */
/* eslint-enable */
