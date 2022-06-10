import styled from "@emotion/styled";
import { Link } from "react-router-dom";

export const Grid = styled.div`
  display: flex;
  flex-wrap: wrap;
  gap: 32px;
`;

export const Product = styled.div`
  width: 300px;
  height: 260px;
  padding: 24px;
  background-color: ${({ theme }) => theme.colors.dark};
  border: ${({ theme }) => `1px solid ${theme.colors.primary}`};
  display: flex;
  flex-direction: column;
  justify-content: space-between;

  a {
    text-decoration: none;
    color: #fff;
    height: 100%;
  }
`;

export const ProductDetails = styled.div`
  display: flex;
  flex-direction: column;
  height: 100%;
`;
export const ImageContainer = styled(Link)`
  height: 170px;
  text-align: center;

  img {
    height: 100%;
  }
`;
export const Wrapper = styled.div`
  margin: 12px 0;
  display: flex;
  align-items: center;

  justify-content: space-between;
`;
export const Name = styled.p`
  cursor: pointer;
  color: #fff;
  font-weight: 400;
  letter-spacing: 0.2px;
`;
export const Price = styled.p``;
export const ShortenedDescription = styled.p`
  font-weight: 300;
  height: 20px;
  margin-bottom: 20px;
  letter-spacing: 0.2px;
  flex: 1;
`;
