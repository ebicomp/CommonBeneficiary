import React, { useEffect, useState } from 'react';
import axios from 'axios';
import { Container, Header, List } from 'semantic-ui-react';
import { RelationType } from '../models/RelationTypes/relationType';
import { NavBar } from './NavBar';
import { RelationTypeDashboard } from '../features/relationTypes/dashboard/RelationTypeDashboard';
import agent from '../api/agent';


function App() {
  const [relationTypes,setRelationTypes]= useState<RelationType[]>([]);

  useEffect(()=>{
    agent.RelationTypes.list().then(response=>{
      console.log(response);
      setRelationTypes(response);
    });


  } , []);
  return (
    <div className="App">
       <NavBar/> 
       <Container style={{marginTop:'4em'}}>
        <Header icon='users' as='h2' content='for test'/>
        <RelationTypeDashboard relationTypes={relationTypes} />
       </Container>

      
    </div>
  );
}

export default App;
