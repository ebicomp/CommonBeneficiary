import { Button, Icon, Table } from "semantic-ui-react";
import { useStore } from "../../../app/stores/store";



export const RelationTypeList = () => {

  const {relationTypeStore} = useStore();
  const {relationTypes} = relationTypeStore;

    return(
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
        relationTypes.map(rl=>(
            <Table.Row key={rl.id}>
            <Table.Cell>{rl.code}</Table.Cell>
            <Table.Cell>{rl.name}</Table.Cell>
            <Table.Cell>
              <Button icon positive >
                <Icon name='eye' />
              </Button>

            </Table.Cell>
          </Table.Row>       
        ))
    }     
    </Table.Body>
    </Table>
    );
}