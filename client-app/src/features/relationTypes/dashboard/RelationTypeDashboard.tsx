import { observer } from "mobx-react-lite";
import { useEffect } from "react";
import { Segment } from "semantic-ui-react";
import { LoadingComponent } from "../../../app/layout/LoadingComponent";
import { useStore } from "../../../app/stores/store";

import { RelationTypeList } from "./RelationTypeList";


 const RelationTypeDashboard = () => {

  const{relationTypeStore} = useStore();

  useEffect(()=>{
    relationTypeStore.loadRelationTypes();
  } , []);

  if(relationTypeStore.loadingInitial) return <LoadingComponent />

      return (
        <Segment>
          <RelationTypeList  />
        </Segment>
    );
}
export default observer(RelationTypeDashboard);