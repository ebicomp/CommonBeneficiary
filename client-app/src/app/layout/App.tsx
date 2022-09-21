
import { Container} from 'semantic-ui-react';
import { NavBar } from './NavBar';
import { observer } from 'mobx-react-lite';
import { Route, Routes } from 'react-router-dom';
import HomePage from '../../features/home/HomePage';
import RelationTypeForm from '../../features/relationTypes/form/RelationTypeForm';
import RelationTypeDashboard from '../../features/relationTypes/dashboard/RelationTypeDashboard';

function App() {

  return (
    <>
       <NavBar/> 
       <Container style={{marginTop:'4em'}}>
        <Routes>
          <Route path="/" element={<HomePage />} />
          <Route path="/relationTypes" element={<RelationTypeDashboard />} />
          <Route path="/relationTypes/:id" element={ <RelationTypeForm /> } />
        </Routes>
       </Container>
    </>
  );
}

export default observer(App);
