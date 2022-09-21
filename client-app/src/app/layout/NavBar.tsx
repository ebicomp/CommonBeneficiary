import React from 'react'
import { NavLink } from 'react-router-dom';
import { Link } from 'react-router-dom';
import { Container, Icon, Menu } from 'semantic-ui-react'

export const NavBar = () => {

    const handleItemClick = () =>{
    }
    let activeItem = 'editorials';

  return (
    <Menu inverted fixed='top'>
    <Container>
        <Menu.Item header as={NavLink} exact="true" to='/'>
        <Icon name='block layout' style={{marginLeft:10}} />
            سامانه ذی نفع واحد
        </Menu.Item>

        <Menu.Item name='relationTypes' as={NavLink} to='/relationTypes'>
          انواع روابط
        </Menu.Item>

        <Menu.Item name='createRelationType' as={NavLink} to= '/createRelationType'>
        ساخت رابطه جدید
        </Menu.Item>

        <Menu.Item name='upcomingEvents' >
        گراف
        </Menu.Item>
    </Container>
  </Menu>
  )
}
    