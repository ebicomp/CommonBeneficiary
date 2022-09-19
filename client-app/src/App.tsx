import React, { useEffect, useState } from 'react';
import axios from 'axios';
import { Header, List } from 'semantic-ui-react';


function App() {
  const [relationTypes,setRelationTypes]= useState([]);

  useEffect(()=>{
    axios.get('http://localhost:5110/api/RelationType').then(response=>{
      console.log(response.data);
      setRelationTypes(response.data);
    });
  } , []);
  return (
    <div className="App">
       <Header icon='users' as='h2' content='for test'/>
       <List>
          {relationTypes.map((rel:any)=>(
            <List.Item>{rel.code}</List.Item>
          ))}
        </List>
      
    </div>
  );
}

export default App;
