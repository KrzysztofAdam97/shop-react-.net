import styled from "@emotion/styled";
import { ContentWrapper } from "styles/globalStyles";

export const Container = styled.footer`
  background-color: ${({ theme }) => theme.colors.dark};
  width: 100%;
  padding: 20px 0;
`;
export const Wrapper = styled(ContentWrapper)`
  display: flex;
  justify-content: space-between;
`;

export const Logo = styled.img`
  width: 100px;
  height: 60px;
`;

export const Githubs = styled.div``;
export const Menu = styled.div``;
export const MenuList = styled.p`
  color: #fff;
  display: block;
  margin: 14px 0;
  text-decoration: none;
`;
