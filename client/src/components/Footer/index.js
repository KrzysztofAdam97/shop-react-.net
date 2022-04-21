import React from "react";
import { Link } from "react-router-dom";
import {
  Container,
  Wrapper,
  Logo,
  Githubs,
  Menu,
  MenuList,
} from "components/Footer/styles";
import LogoImage from "assets/logo.png";

import GithubsList from "constants/githubs.json";
import MenuItems from "constants/menuItems.json";

function Footer() {
  return (
    <Container>
      <Wrapper>
        <Logo src={LogoImage} alt="pcvolt logo" />
        <Githubs>
          {GithubsList?.map((github) => (
            <MenuList as="a" key={github.id} href={github.link}>
              {github.name}
            </MenuList>
          ))}
        </Githubs>
        <Menu>
          {MenuItems?.map((item) => (
            <Link to={item.link} key={item.id}>
              <MenuList>{item.name}</MenuList>
            </Link>
          ))}
        </Menu>
      </Wrapper>
    </Container>
  );
}

export default Footer;
