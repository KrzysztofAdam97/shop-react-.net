import styled from "@emotion/styled";
import { ContentWrapper } from "styles/globalStyles";

export const Container = styled.nav`
  background-color: ${({ theme }) => theme.colors.secondary};
  height: 65px;
`;
export const Wrapper = styled(ContentWrapper)`
  display: flex;
  justify-content: space-between;
  align-items: center;
  height: 100%;
`;
export const Logo = styled.img`
  width: 95px;
  cursor: pointer;
`;

export const NavMenu = styled.div`
  display: flex;
`;

export const AccountWrapper = styled.div``;

export const Button = styled.button`
  background-color: ${({ theme }) => theme.colors.secondary};
  border: ${({ theme }) => `3px solid ${theme.colors.dark}`};
  color: #fff;
  min-width: 120px;
  min-height: 40px;
  text-transform: uppercase;
  font-size: 12px;
  font-weight: 600;
  border-radius: 10px;
  cursor: pointer;
`;

export const CartLogo = styled.img`
  width: 40px;
  margin-left: 10px;
  cursor: pointer;
`;
