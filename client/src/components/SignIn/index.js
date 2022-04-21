import React from "react";
import { Link } from "react-router-dom";
import {
  Container,
  Form,
  Label,
  Input,
  Button,
  Anchor,
} from "components/SignIn/styles";

function SignIn() {
  return (
    <Container>
      <Form>
        <Label>Nazwa uzytkownika</Label>
        <Input type="text" />
        <Label>Hasło</Label>
        <Input type="password" />
        <Button>Zaloguj się</Button>
        <Anchor>
          Nie masz jeszcze konta? <Link to="/rejestracja">Zarejestruj się</Link>
        </Anchor>
      </Form>
    </Container>
  );
}

export default SignIn;
