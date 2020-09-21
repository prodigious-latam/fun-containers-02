import { City } from "./City";

export const getCitiesByCountry = async (country_id:string):Promise<City[]> => {

    return await fetch(process.env.REACT_APP_API_URL + `/city?country_id=${country_id}`)
        .then(response => {
            return response.json();
        });
}