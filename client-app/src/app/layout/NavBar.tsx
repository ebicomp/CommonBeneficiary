import React from 'react'
import { Container, Icon, Menu } from 'semantic-ui-react'

export const NavBar = () => {

    const handleItemClick = () =>{
    }
    let activeItem = 'editorials';

  return (
    <Menu inverted fixed='top'>
    <Container>
        <Menu.Item header>
        <Icon name='block layout' style={{marginLeft:10}} />
            سامانه ذی نفع واحد
            </Menu.Item>
        <Menu.Item
        name='editorials'
        active={activeItem === 'editorials'}
        onClick={handleItemClick}
        >
        انواع روابط
        </Menu.Item>

        <Menu.Item
        name='reviews'
        active={activeItem === 'reviews'}
        onClick={handleItemClick}
        >
        ذی نفع واحد
        </Menu.Item>

        <Menu.Item
        name='upcomingEvents'
        active={activeItem === 'upcomingEvents'}
        onClick={handleItemClick}
        >
        گراف
        </Menu.Item>
    </Container>
  </Menu>
  )
}
    