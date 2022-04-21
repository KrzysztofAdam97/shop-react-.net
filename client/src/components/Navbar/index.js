import React from "react";
import { Link } from "react-router-dom";
import {
  Container,
  Wrapper,
  Logo,
  NavMenu,
  AccountWrapper,
  Button,
  CartLogo,
} from "components/Navbar/styles";

import LogoImage from "assets/logo.png";
import CartImage from "assets/cart.png";

function Navbar() {
  return (
    <Container>
      <Wrapper>
        <Link to="/">
          <Logo alt="pcvolt logo" src={LogoImage} />
        </Link>
        <NavMenu>
          <AccountWrapper></AccountWrapper>
          <Link to="/logowanie">
            <Button>Zaloguj się</Button>
          </Link>
          <Link to="/koszyk">
            <CartLogo alt="cart" src={CartImage} />
          </Link>
        </NavMenu>
      </Wrapper>
    </Container>
  );
}

export default Navbar;
