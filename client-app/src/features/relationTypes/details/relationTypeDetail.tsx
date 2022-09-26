import { observer } from 'mobx-react-lite';
import React, { useEffect } from 'react'
import { NavLink, useNavigate } from 'react-router-dom';
import { useParams } from 'react-router-dom';
import { Button, ButtonGroup, Card, Icon , Image } from 'semantic-ui-react'
import { LoadingComponent } from '../../../app/layout/LoadingComponent';
import { useStore } from '../../../app/stores/store';

const RelationTypeDetail = () => {
    const navigate = useNavigate();
    const {relationTypeStore} = useStore();
    const{ loadingInitial , loadRelationType , selectedRelationType ,deleteRelationType} = relationTypeStore;
    const {id} = useParams<{id:string}>();
    useEffect(()=>{
        if(id){
            const idInt = Number.parseInt(id);
            loadRelationType(idInt);
        }
    } , [id , loadRelationType]);

    if(loadingInitial || !selectedRelationType) return <LoadingComponent />


    const handleRemove = (id:number)=>{
        deleteRelationType(id);
        navigate('/relationTypes');
    }

  return (
    <Card fluid>
    {/* <Image src='/images/relationships.png' wrapped ui={false} /> */}
    <Card.Content>
      <Card.Header>{selectedRelationType.name}</Card.Header>
      <Card.Meta>
        <span className='date'>{selectedRelationType.code}</span>
      </Card.Meta>
      <Card.Description>
        
      </Card.Description>
    </Card.Content>
    <Card.Content extra>
        <ButtonGroup widths='3' basic>
            <Button basic as={NavLink} to='/relationTypes'>
                بازگشت
                <Icon name='cancel'></Icon>
            </Button>
            <Button basic as={NavLink} to={`/updateRelatoinType/${selectedRelationType.id}`}>
                ویرایش
                <Icon name='edit'></Icon>
            </Button>

            <Button onClick={() =>handleRemove(selectedRelationType.id)}>
                حذف
                <Icon name='remove circle'></Icon>
            </Button>
        </ButtonGroup>
    </Card.Content>
  </Card>
  )
}
export default observer(RelationTypeDetail);