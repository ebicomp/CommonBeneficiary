import { Grid, List, Segment } from "semantic-ui-react";
import RelationTypeForm from "../form/RelationTypeForm";

import { RelationTypeList } from "./RelationTypeList";


export const RelationTypeDashboard = () => {
      return (
        <Segment>
          <RelationTypeList  />
          <RelationTypeForm />
        </Segment>
    );
}