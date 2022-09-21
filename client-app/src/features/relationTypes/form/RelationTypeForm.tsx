import { observer } from "mobx-react-lite";
import { ChangeEvent, useState } from "react";
import { Button, Form, Segment } from "semantic-ui-react"
import { useStore } from "../../../app/stores/store";



 const RelationTypeForm = () => {
    const{relationTypeStore} = useStore();
    const{selectedRelationType , updateRelationType , createRelationType} = relationTypeStore;
    const initialState = selectedRelationType??{
        id:0,
        code:'',
        name:''
    };
    const [relationType, setRelationType] = useState(initialState); 

    const handleSubmit = ()=>{
        relationType.id? updateRelationType(relationType): createRelationType(relationType);
    }

    const handleCHange= (event:ChangeEvent<HTMLInputElement>)=>{
        const{name , value}= event.target;
        setRelationType({...relationType, [name]:value })
    }
return(
    <Segment clearing >
        <Form onSubmit={handleSubmit}>
            <Form.Field value={relationType.id} />
            <Form.Input placeholer='کد رابطه' name='id' value={relationType.code} onChange={handleCHange} />
            <Form.Input placeholer='نام رابطه' name='code' value={relationType.name} onChange={handleCHange}/>
            <Button floated="left" positive type="submit" content='ثبت'/>
            <Button floated="left" positive content='انصراف'/>
        </Form>
    </Segment>
)
}
export default observer(RelationTypeForm) ;