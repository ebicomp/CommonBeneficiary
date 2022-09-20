import { Grid, List, Segment } from "semantic-ui-react";
import { RelationType } from "../../../models/RelationTypes/relationType";
import { RelationTypeForm } from "../form/RelationTypeForm";
import { RelationTypeList } from "./RelationTypeList";

interface Props{
    relationTypes:RelationType[];
}
export const RelationTypeDashboard = ({relationTypes}:Props) => {
      return (
        <Segment>
          <RelationTypeList relationTypes={relationTypes} />
          <RelationTypeForm relationtype={relationTypes[0]} />
        </Segment>
    );
}