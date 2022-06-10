import axios from "axios";
import MockAdapter from "axios-mock-adapter";

const config = {
  baseURL: "http://localhost:5000/api",
  timeout: 15000,
  headers: {
    "Content-Type": "application/json",
    "Access-Control-Allow-Origin": true,
  },
};

export const API = axios.create(config);

export const APIRoutes = {
  testProduct: (id) => `/testProduct/${id}`,
  test: "/test",
  products: "/Products",
  product: (id) => `/Product/${id}`,
};

export const APIMock = new MockAdapter(API, {
  delayResponse: 3000,
  onNoMatch: "passthrough",
});

APIMock.onGet(APIRoutes.testProduct(2)).reply(200, {
  id_product: 1,
  name_product: "Intel core i3 9350K",
  description_product:
    "Procesor marki intel 9 generacji, taktowanie do 4,20GHz, 8 MB Cache",
  price: 1400,
  in_stock: 4,
  id_category: 1,
});

APIMock.onGet(APIRoutes.test).reply(200, [
  {
    id_product: 1,
    name_product: "Intel core i3 9350K",
    description_product:
      "Procesor marki intel 9 generacji, taktowanie do 4,20GHz, 8 MB Cache",
    price: 1400,
    in_stock: 4,
    id_category: 1,
  },
  {
    id_product: 2,
    name_product: "Intel core i5 11250F",
    description_product:
      "Procesor marki intel 5 generacji, taktowanie do 4,60GHz, 8 MB Cache",
    price: 1500,
    in_stock: 6,
    id_category: 1,
  },
  {
    id_product: 3,
    name_product: "Intel core i5 11250F",
    description_product:
      "Procesor marki intel 5 generacji, taktowanie do 4,60GHz, 8 MB Cache",
    price: 1500,
    in_stock: 6,
    id_category: 1,
  },
  {
    id_product: 4,
    name_product: "Intel core i5 11250F",
    description_product:
      "Procesor marki intel 5 generacji, taktowanie do 4,60GHz, 8 MB Cache",
    price: 1500,
    in_stock: 6,
    id_category: 1,
  },
  {
    id_product: 5,
    name_product: "Intel core i5 11250F",
    description_product:
      "Procesor marki intel 5 generacji, taktowanie do 4,60GHz, 8 MB Cache",
    price: 1500,
    in_stock: 6,
    id_category: 1,
  },
  {
    id_product: 5,
    name_product: "Intel core i5 11250F",
    description_product:
      "Procesor marki intel 5 generacji, taktowanie do 4,60GHz, 8 MB Cache",
    price: 1500,
    in_stock: 6,
    id_category: 1,
  },
  {
    id_product: 5,
    name_product: "Intel core i5 11250F",
    description_product:
      "Procesor marki intel 5 generacji, taktowanie do 4,60GHz, 8 MB Cache",
    price: 1500,
    in_stock: 6,
    id_category: 1,
  },
  {
    id_product: 5,
    name_product: "Intel core i5 11250F",
    description_product:
      "Procesor marki intel 5 generacji, taktowanie do 4,60GHz, 8 MB Cache",
    price: 1500,
    in_stock: 6,
    id_category: 1,
  },
  {
    id_product: 5,
    name_product: "Intel core i5 11250F",
    description_product:
      "Procesor marki intel 5 generacji, taktowanie do 4,60GHz, 8 MB Cache",
    price: 1500,
    in_stock: 6,
    id_category: 1,
  },
  {
    id_product: 5,
    name_product: "Intel core i5 11250F",
    description_product:
      "Procesor marki intel 5 generacji, taktowanie do 4,60GHz, 8 MB Cache",
    price: 1500,
    in_stock: 6,
    id_category: 1,
  },
  {
    id_product: 5,
    name_product: "Intel core i5 11250F",
    description_product:
      "Procesor marki intel 5 generacji, taktowanie do 4,60GHz, 8 MB Cache",
    price: 1500,
    in_stock: 6,
    id_category: 1,
  },
  {
    id_product: 5,
    name_product: "Intel core i5 11250F",
    description_product:
      "Procesor marki intel 5 generacji, taktowanie do 4,60GHz, 8 MB Cache",
    price: 1500,
    in_stock: 6,
    id_category: 1,
  },
  {
    id_product: 5,
    name_product: "Intel core i5 11250F",
    description_product:
      "Procesor marki intel 5 generacji, taktowanie do 4,60GHz, 8 MB Cache",
    price: 1500,
    in_stock: 6,
    id_category: 1,
  },
  {
    id_product: 5,
    name_product: "Intel core i5 11250F",
    description_product:
      "Procesor marki intel 5 generacji, taktowanie do 4,60GHz, 8 MB Cache",
    price: 1500,
    in_stock: 6,
    id_category: 1,
  },
]);
