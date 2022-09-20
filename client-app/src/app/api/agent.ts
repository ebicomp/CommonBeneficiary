import axios, { AxiosResponse } from "axios";
import { RelationType } from "../models/RelationTypes/relationType";
axios.defaults.baseURL = 'http://localhost:5110/api';

const responseBody = <T> (response:AxiosResponse<T>)=>response.data;

const requests = {
 get:<T> (url:string)=> axios.get<T>(url).then(responseBody),
 post:<T> (url:string,body:{})=> axios.post<T> (url,body).then(responseBody),
 put:<T> (url:string,body:{})=> axios.put<T> (url,body).then(responseBody),
 delete:<T> (url:string)=> axios.delete<T> (url).then(responseBody)
}

const RelationTypes ={
    list: ()=> requests.get<RelationType[]>('/relationType')
}

const agent ={
RelationTypes
}
export default agent;