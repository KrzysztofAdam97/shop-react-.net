import { useState, useEffect } from "react";
import { Link } from "react-router-dom";
import { API, APIRoutes } from "utils/api";
import { css } from "@emotion/react";

import {
  Grid,
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

function Products() {
  const [products, setProducts] = useState([]);
  const [isLoading, setIsLoading] = useState(false);
  useEffect(() => {
    (async () => {
      setIsLoading(true);
      const { data } = await API.get(APIRoutes.products);
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
          <Product key={product.id_product}>
            <Link to={`/product/${product.id_product}`}>
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
            </Link>
          </Product>
        ))
      )}
    </Grid>
  );
}

export default Products;
