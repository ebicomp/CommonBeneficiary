import { Button, Table } from "semantic-ui-react";
import { RelationType } from "../../../models/RelationTypes/relationType";


interface Props{
    relationTypes:RelationType[];
}

export const RelationTypeList = ({relationTypes}:Props) => {
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
            <Table.Cell><Button positive content='ویرایش'/></Table.Cell>
          </Table.Row>       
        ))
    }
     
      
    </Table.Body>
    </Table>
    );
}