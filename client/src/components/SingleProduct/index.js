import React, { useState, useEffect } from "react";
import { useParams } from "react-router-dom";
import { API, APIRoutes } from "utils/api";
import { css } from "@emotion/react";

import {
  Product,
  ProductDetails,
  Wrapper,
  Name,
  Price,
  ShortenedDescription,
} from "components/Products/styles.js";

import ClipLoader from "react-spinners/ClipLoader";

const override = css`
  position: absolute;
  top: 50%;
  left: 50%;
  width: 50px;
  height: 50px;
  transform: translate(-50%, -50%);
`;

const SingleProduct = () => {
  const [product, setProduct] = useState({});
  const [isLoading, setIsLoading] = useState(false);
  const { id } = useParams();

  useEffect(() => {
    (async () => {
      setIsLoading(true);
      const { data } = await API.get(APIRoutes.product(id));
      setProduct(data);
      setIsLoading(false);
    })();
  }, []);

  return isLoading ? (
    <ClipLoader color="#ffffff" css={override} size={150} />
  ) : (
    <Product key={product.id_product}>
      <ProductDetails>
        <Wrapper>
          <Name>{product.name_product}</Name>
        </Wrapper>
        <ShortenedDescription>
          {product.description_product}
        </ShortenedDescription>
        <Wrapper>
          <Price>{product.price} PLN</Price>
          <Price>{product.in_stock} w magazynie</Price>
        </Wrapper>
      </ProductDetails>
    </Product>
  );
};

export default SingleProduct;
