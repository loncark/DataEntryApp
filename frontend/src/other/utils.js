import { BACKEND_BASE_URL } from './constants'

export async function query(endpoint, method, body) {
    try {
        const response = await fetch(BACKEND_BASE_URL + endpoint, {
            method: method,
            headers: {
                'Content-Type': 'application/json'
            },
            body: body
        });
    
        return response.status;
    }
    catch (error) {
        console.log(error);
    }
}