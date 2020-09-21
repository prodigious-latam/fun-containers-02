import { Country } from "./Country";

export const getAllCountries = async ():Promise<Country[]> => {

    return await fetch(process.env.REACT_APP_API_URL + '/country')
        .then(response => {
            return response.json();
        });
}