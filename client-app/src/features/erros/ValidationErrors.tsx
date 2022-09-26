import React from 'react'
import { Message } from 'semantic-ui-react';

interface Props{
    errors:string[];
}

const ValidationErrors = ({errors}:Props) => {
  return (
    <Message>
    <Message.Header>خطا</Message.Header>
    <Message.List>
        {
            errors.map(err=><Message.Item>{err}</Message.Item>
            )
        }
    </Message.List>
  </Message>
  )
}
export default ValidationErrors