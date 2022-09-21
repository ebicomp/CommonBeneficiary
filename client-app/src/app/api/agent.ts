import { RelationType } from './../models/RelationTypes/relationType';
import axios, { AxiosResponse } from "axios";
axios.defaults.baseURL = 'http://localhost:5110/api';

const responseBody = <T> (response:AxiosResponse<T>)=>response.data;

const requests = {
 get:<T> (url:string)=> axios.get<T>(url).then(responseBody),
 post:<T> (url:string,body:{})=> axios.post<T> (url,body).then(responseBody),
 put:<T> (url:string,body:{})=> axios.put<T> (url,body).then(responseBody),
 delete:<T> (url:string)=> axios.delete<T> (url).then(responseBody)
}

const RelationTypes ={
    list: ()=> requests.get<RelationType[]>('/relationType'),
    details:(id:number)=> requests.get<RelationType>(`/relationType/${id}`),
    create:(relatoinType:RelationType)=> requests.post<RelationType>('/relationType', relatoinType),
    update:(RelationType:RelationType)=> requests.put<RelationType>('/relationType',RelationType),
    delete:(id:number) => requests.delete<RelationType>(`/relationType/${id}`)
}

const agent ={
RelationTypes
}
export default agent;