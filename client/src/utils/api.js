import axios from "axios";
import MockAdapter from "axios-mock-adapter";

const config = {
  baseURL: "http://localhost:8080",
  timeout: 15000,
  headers: {
    "Content-Type": "application/json",
  },
};

export const API = axios.create(config);

export const APIRoutes = {
  test: "/test",
};

export const APIMock = new MockAdapter(API, {
  delayResponse: 3000,
  onNoMatch: "passthrough",
});

APIMock.onGet(APIRoutes.test).reply(200, [
  {
    id: 1,
    name: "Testowy przedmiot",
    description:
      "Cras dapibus vel massa non dignissim. Pellentesque posuere porta enim, sit amet tristique sapien faucibus cursus. Fusce tempor ligula nec neque pulvinar ultrices. Nullam ullamcorper sit amet sem a venenatis. Ut id metus facilisis, suscipit tortor non, blandit augue. Nulla ullamcorper sapien sit amet enim bibendum aliquet. Maecenas pulvinar sed dolor a volutpat.",
    price: 100,
    imageUrl: "https://via.placeholder.com/200/09f/fff.png",
    type: "graphic_card",
    brand: "MSI",
    category: "gaming",
    stock: 3,
  },
  {
    id: 2,
    name: "Testowy przedmiot 2",
    description:
      "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vivamus pulvinar feugiat convallis. Fusce sed lorem ullamcorper, ultricies velit a, mattis purus. Sed eu urna ac diam imperdiet hendrerit a at sapien. Cras metus ipsum, congue et lectus sed, egestas consequat mauris. Phasellus laoreet malesuada auctor. Vestibulum dictum enim sem, vel aliquam nisl placerat eget. Suspendisse arcu purus, blandit vel imperdiet sed, ultrices eget leo. Sed lobortis felis eu arcu lacinia, id fringilla mauris egestas. Mauris lacinia augue sit amet porta tempor.",
    price: 159,
    imageUrl: "https://via.placeholder.com/200/d4f/fff.png",
    type: "graphic_card",
    brand: "MSI",
    category: "gaming",
    stock: 3,
  },
]);
