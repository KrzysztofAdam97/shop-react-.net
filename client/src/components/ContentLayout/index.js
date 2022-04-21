import React from "react";
import { Container, Wrapper } from "components/ContentLayout/styles";

function Layout({ children }) {
  return (
    <Container>
      <Wrapper>{children}</Wrapper>
    </Container>
  );
}

export default Layout;
