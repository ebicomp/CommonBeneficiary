import React from 'react'
import { Link } from 'react-router-dom'
import { NavLink } from 'react-router-dom'
import { Button, Header, Icon, Segment } from 'semantic-ui-react'

const NotFound = () => {
  return (
    <Segment placeholder style={{textAlign :'center'}}>
    <Header icon>
      <Icon name='search' />
      برای درخواست شما پاسخی یافت نشد
    </Header>
    <Button primary as={Link} to='/'>بازگشت به صفحه اصلی</Button>
  </Segment>
  )
}

export default NotFound