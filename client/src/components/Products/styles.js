import styled from "@emotion/styled";
import { Link } from "react-router-dom";

export const Grid = styled.div`
  display: flex;
  gap: 32px;
`;

export const Product = styled.div`
  width: 304px;
  height: 324px;
  padding: 24px;
  background-color: ${({ theme }) => theme.colors.dark};
  border: ${({ theme }) => `1px solid ${theme.colors.primary}`};
  display: flex;
  flex-direction: column;
  justify-content: space-between;

  a {
    text-decoration: none;
  }
`;

export const ProductDetails = styled.div``;
export const ImageContainer = styled(Link)`
  height: 170px;
  text-align: center;

  img {
    height: 100%;
  }
`;
export const Top = styled.div`
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
  white-space: nowrap;
  overflow: hidden;
  display: block;
  text-overflow: ellipsis;
  font-weight: 300;
  height: 20px;
  letter-spacing: 0.2px;
`;
export const Button = styled.button`
  width: 100%;
  height: 40px;
  border: none;
  border-radius: 5px;
  margin-top: 10px;
  color: ${({ theme }) => theme.colors.dark};
  background-color: ${({ theme }) => theme.colors.primary};
  cursor: pointer;
  transition: all 0.3s;

  &:hover {
    background-color: ${({ theme }) => theme.colors.secondary};
    color: #fff;
  }
`;
