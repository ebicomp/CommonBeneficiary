import React, { useEffect, useState } from 'react';
import axios from 'axios';
import { Container, Header, List } from 'semantic-ui-react';
import { RelationType } from '../models/RelationTypes/relationType';
import { NavBar } from './NavBar';


function App() {
  const [relationTypes,setRelationTypes]= useState<RelationType[]>([]);

  useEffect(()=>{
    axios.get<RelationType[]>('http://localhost:5110/api/RelationType').then(response=>{
      console.log(response.data);
      setRelationTypes(response.data);
    });
  } , []);
  return (
    <div className="App">
       <NavBar/> 
       <Container style={{marginTop:'4em'}}>
        <Header icon='users' as='h2' content='for test'/>
        <List>
            {relationTypes.map((rel)=>(
              <List.Item>{rel.code}</List.Item>
            ))}
          </List>
       </Container>

      
    </div>
  );
}

export default App;
