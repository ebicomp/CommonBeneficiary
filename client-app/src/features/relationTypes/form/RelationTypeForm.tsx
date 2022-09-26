import { observer } from "mobx-react-lite";
import { ChangeEvent, useEffect, useState } from "react";
import { NavLink } from "react-router-dom";
import { Button, Form, Segment } from "semantic-ui-react"
import { useStore } from "../../../app/stores/store";
import { useParams } from "react-router-dom";
import { LoadingComponent } from "../../../app/layout/LoadingComponent";
import { useNavigate  } from "react-router-dom";



 const RelationTypeForm = () => {
    const navigate = useNavigate();

    const{relationTypeStore} = useStore();
    const{updateRelationType , createRelationType,loadRelationType,loadingInitial} = relationTypeStore;
    let {id} = useParams<{id:string}>();

    const [relationType, setRelationType] = useState({
        id:0,
        code:'',
        name:''
    }); 

    useEffect(()=>{
        if(id){
            const idInt = Number.parseInt(id);
            loadRelationType(idInt).then(relationtype=>{
                 setRelationType(relationtype!);
            });
        }
    } , [id, loadRelationType])

    if(loadingInitial) return <LoadingComponent />


    const handleSubmit = ()=>{
        console.log(relationType);
        // relationType.id ===0 ?  createRelationType(relationType) :updateRelationType(relationType);

        if(relationType.id ===0){
            createRelationType(relationType).then(Response=>console.log('error from from ' + Response));
        }
        else{
            updateRelationType(relationType).then(Response=>console.log('error from from ' + Response));
        }
        // navigate('/relationTypes');
    }

    const handleCHange= (event:ChangeEvent<HTMLInputElement>)=>{
        const{name , value}= event.target;
        setRelationType({...relationType, [name]:value });
    }
return(
    <Segment clearing >
        <Form onSubmit={handleSubmit}>
            <Form.Field value={relationType.id} />
            <Form.Input placeholer='کد رابطه' label='کد رابطه' name='code' value={relationType.code} onChange={handleCHange} />
            <Form.Input placeholer='نام رابطه' label='نام رابطه' name='name' value={relationType.name} onChange={handleCHange}/>
            <Button floated="left" positive type="submit" content='ثبت'/>
            <Button floated="left" positive content='انصراف' as={NavLink}  to='/relationTypes' />
        </Form>
    </Segment>
)
}
export default observer(RelationTypeForm) ;