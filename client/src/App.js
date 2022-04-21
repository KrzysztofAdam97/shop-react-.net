import React, { useEffect } from "react";
import { Routes, Route, useLocation } from "react-router-dom";

import { ThemeProvider } from "@emotion/react";
import theme from "styles/theme";
import GlobalStyles from "styles/globalStyles.js";

import {
  Navbar,
  Footer,
  Layout,
  Products,
  Checkout,
  SignIn,
  SignUp,
} from "components";

function App() {
  const location = useLocation();

  useEffect(() => {
    window.scrollTo(0, 0);
  }, [location.pathname]);
  return (
    <>
      <ThemeProvider theme={theme}>
        <GlobalStyles />
        <Navbar />
        <Layout>
          <Routes>
            <Route path="/" element={<Products />} />
            <Route path="/koszyk" element={<Checkout />} />
            <Route path="/logowanie" element={<SignIn />} />
            <Route path="/rejestracja" element={<SignUp />} />
          </Routes>
        </Layout>
        <Footer />
      </ThemeProvider>
    </>
  );
}

export default App;
