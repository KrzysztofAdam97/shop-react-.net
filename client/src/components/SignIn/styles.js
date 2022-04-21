import styled from "@emotion/styled";

export const Container = styled.section`
  width: 100%;
  height: 100%;
  display: flex;
  align-items: center;
  justify-content: center;
`;
export const Form = styled.form`
  background-color: ${({ theme }) => theme.colors.secondary};
  display: flex;
  flex-direction: column;
  min-width: 350px;
  padding: 30px;
`;
export const Label = styled.label`
  font-weight: 400;
  letter-spacing: 0.5px;
  font-size: 14px;
`;
export const Input = styled.input`
  margin: 5px 0 15px 0;
  padding: 8px 12px;
`;
export const Button = styled.button`
  background-color: ${({ theme }) => theme.colors.secondary};
  border: ${({ theme }) => `3px solid ${theme.colors.dark}`};
  color: #fff;
  width: 100%;
  min-height: 40px;
  text-transform: uppercase;
  font-size: 12px;
  font-weight: 600;
  border-radius: 10px;
  cursor: pointer;
  margin-top: 10px;
`;
export const Anchor = styled.p`
  font-weight: 400;
  letter-spacing: 0.5px;
  font-size: 14px;
  margin-top: 10px;

  a {
    text-decoration: none;
    color: ;
  }
`;
