import React, { useEffect, useState } from 'react';
import axios from 'axios';
import { Container, Header, List } from 'semantic-ui-react';
import { RelationType } from '../models/RelationTypes/relationType';
import { NavBar } from './NavBar';
import { RelationTypeDashboard } from '../../features/relationTypes/dashboard/RelationTypeDashboard';
import agent from '../api/agent';
import { useStore } from '../stores/store';
import { observer } from 'mobx-react-lite';
import { LoadingComponent } from './LoadingComponent';


function App() {
  const{relationTypeStore} = useStore();


  useEffect(()=>{
    relationTypeStore.loadRelationTypes();
  } , []);

  if(relationTypeStore.loadingInitial) return <LoadingComponent />

  return (
    <div className="App">
       <NavBar/> 
       <Container style={{marginTop:'4em'}}>
        <Header icon='users' as='h2' content='for test'/>
        <RelationTypeDashboard />
       </Container>

      
    </div>
  );
}

export default observer(App);
