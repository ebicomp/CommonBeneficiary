import { observer } from "mobx-react-lite";
import { NavLink } from "react-router-dom";
import { Button, Icon, Table } from "semantic-ui-react";
import { useStore } from "../../../app/stores/store";



 const RelationTypeList = () => {

  const {relationTypeStore} = useStore();
  const {relationTypes} = relationTypeStore;

    return(
      <>
    <Table celled>
    <Table.Header>
      <Table.Row>
        <Table.HeaderCell>کد رابطه</Table.HeaderCell>
        <Table.HeaderCell>عنوان رابطه</Table.HeaderCell>
        <Table.HeaderCell>عملیات</Table.HeaderCell>
      </Table.Row>
    </Table.Header>

    <Table.Body>
    {
        relationTypes.map(rl=>{
          return (
            <Table.Row key={rl.id}>
              <Table.Cell>{rl.code}</Table.Cell>
              <Table.Cell>{rl.name}</Table.Cell>
              <Table.Cell>
                <Button icon positive as={NavLink} to ={`/relationTypeDetail/${rl.id}`}>
                  <Icon name='eye' />
                </Button>

              </Table.Cell>
            </Table.Row>
          );
        })
    }     
    </Table.Body>
    </Table>
      <Button positive as={NavLink} to='/createRetionType'>
        ایجاد رابطه جدید
        <Icon name="cog"/>
        </Button>
    </>
    );
}

export default observer(RelationTypeList);