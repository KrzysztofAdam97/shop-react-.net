import { useState, useEffect } from "react";
import { Link } from "react-router-dom";
import { API, APIRoutes } from "utils/api";
import { css } from "@emotion/react";

import {
  Grid,
  Product,
  ProductDetails,
  Top,
  Name,
  Price,
  ShortenedDescription,
  ImageContainer,
  Button,
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

function Products() {
  const [products, setProducts] = useState([]);
  const [isLoading, setIsLoading] = useState(false);
  useEffect(() => {
    (async () => {
      setIsLoading(true);
      const { data } = await API.get(APIRoutes.test);
      setProducts(data);
      setIsLoading(false);
    })();
  }, []);

  return (
    <Grid>
      {isLoading ? (
        <ClipLoader color="#ffffff" css={override} size={150} />
      ) : (
        products?.map((product) => (
          <Product key={product.id}>
            <ImageContainer to={`/product/${product.id}`}>
              <img src={product.imageUrl} alt="" />
            </ImageContainer>
            <ProductDetails>
              <Top>
                <Link to={`/product/${product.id}`}>
                  <Name>{product.name}</Name>
                </Link>
                <Price>{product.price} PLN</Price>
              </Top>
              <ShortenedDescription>{product.description}</ShortenedDescription>
              <Button>Dodaj do koszyka</Button>
            </ProductDetails>
          </Product>
        ))
      )}
    </Grid>
  );
}

export default Products;
