import { RelationType } from './../models/RelationTypes/relationType';
import axios, { AxiosError, AxiosResponse } from "axios";
import { toast } from 'react-toastify';

axios.defaults.baseURL = 'http://localhost:5110/api';

axios.interceptors.response.use(async response =>{
    return response;
}
// , (error:AxiosError)=>{
//     const {data , status} = error.response!;
//     switch(status){
//         case 400:
//             toast.error('bad request');
//             break;
//         case 401:
//             toast.error('unauthorized');
//             break;

//         case 404:
//             toast.error('not found');
//             break;

//         case 500:
//             toast.error('server error');
//             break;

//     }
//     return Promise.reject(error);
// }
);

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
    update:(RelationType:RelationType)=> requests.put<RelationType>(`/relationType/${RelationType.id}`,RelationType),
    delete:(id:number) => requests.delete<RelationType>(`/relationType/${id}`)
}

const agent ={
RelationTypes
}
export default agent;