import { RelationType } from './../models/RelationTypes/relationType';
import { makeObservable, observable, action, makeAutoObservable } from "mobx"
import agent from '../api/agent';

export default class RelationTypeStore {

    // relationTypes:RelationType[] = [];
    relationTypeRegistry = new Map<number , RelationType>();
    selectedRelationType: RelationType|undefined = undefined;
    editMode =false;
    loading = false;
    loadingInitial = false;
    
    constructor() {
        makeAutoObservable(this);
    }
    get relationTypes(){
        return Array.from(this.relationTypeRegistry.values());
    }

    loadRelationTypes =async ()=>{
        this.setLoadingInitial(true);
        try{
            const relationTypesResponse = await agent.RelationTypes.list();
            relationTypesResponse.forEach(rel =>{
                this.relationTypeRegistry.set(rel.id , rel);
            });
            this.setLoadingInitial(false);

        }catch(error){
            console.log(error);
            this.setLoadingInitial(false);
        }
    }
    loadRelationType = async(id:number)=>{
        this.setLoadingInitial(true);
        try{
            const relationType = await agent.RelationTypes.details(id);
            this.setRelationType(relationType);
            this.setLoadingInitial(false);
            return relationType;

        }catch(error){
            console.log(error);
            this.setLoadingInitial(false);
        }

    }
    setRelationType=(relationType:RelationType)=>
    {
        this.selectedRelationType = relationType;
    }

    setLoadingInitial = (state:boolean)=>{
        this.loadingInitial = state;
    }

    selectRelationType = (id:number)=>{
        // this.selectedRelationType = this.relationTypes.find(q=>q.id === id);
        this.selectedRelationType = this.relationTypeRegistry.get(id);
    }
    cancelSelectedRelationType = ()=>{
        this.selectedRelationType = undefined;
    }
    createRelationType = async(relationType:RelationType)=>{
        this.loading = true;
        try{
            await agent.RelationTypes.create(relationType);
            // this.relationTypes.push(relationType);
            this.relationTypeRegistry.set(relationType.id , relationType);
            this.selectedRelationType = relationType;
            this.loading = false;
        }catch(error){
            console.log(error);
            this.loading = false;
        }
    }
    updateRelationType = async(relationType:RelationType)=>{
        this.loading = true;
        try{
            await agent.RelationTypes.update(relationType);
            // this.relationTypes = [...this.relationTypes.filter(q=>q.id !== relationType.id), relationType];
            this.relationTypeRegistry.set(relationType.id , relationType);
            this.selectedRelationType = relationType;
            this.loading = false;

        }catch(error){
            console.log(error);
            this.loading = false;
        }
    }
    deleteRelationType = async(id:number)=>{
        this.loading = true;
        try{
            await agent.RelationTypes.delete(id);
            // this.relationTypes = [...this.relationTypes.filter(q=>q.id !== id)];
            this.relationTypeRegistry.delete(id);
            this.loading = false;
        }
        catch(error){
            this.loading = false;
        }
    }
    
}