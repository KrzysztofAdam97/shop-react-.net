import React from "react";
import { css, Global, useTheme } from "@emotion/react";
import emotionReset from "emotion-reset";
import styled from "@emotion/styled";

function GlobalStyles() {
  const theme = useTheme();

  return (
    <Global
      styles={css`
        ${emotionReset}

        *,
        *:after,
        *:before {
          box-sizing: border-box;
          -webkit-font-smoothing: subpixel-antialiased;
          -moz-osx-font-smoothing: grayscale;
          padding: 0;
          margin: 0;
        }

        body {
          font-family: ${theme.defaults.fontFamily.primary};
        }
      `}
    />
  );
}

export const ContentWrapper = styled.div`
  width: 100%;
  max-width: ${({ theme }) => theme.layoutMaxWidth}px;
  margin: 0 auto;

  @media screen and (max-width: 1350px) {
    padding: 0 15px;
  }
`;

export default GlobalStyles;
