import styled from "@emotion/styled";
import { ContentWrapper } from "styles/globalStyles";
import Background from "assets/background.png";

export const Container = styled.main`
  width: 100%;
  min-height: 600px;
  height: 100vh;
  max-height: 1600px;
  background: url(${Background}) no-repeat;
  background-size: cover;
`;
export const Wrapper = styled(ContentWrapper)`
  padding: 50px 0;
  color: #fff;
  height: 100%;
`;
