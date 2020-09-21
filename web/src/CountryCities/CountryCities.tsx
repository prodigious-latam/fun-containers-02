import React, { Fragment, useEffect, useState } from 'react';
import { Dropdown, DropdownButton, Form, TabContainer, Table } from 'react-bootstrap';
import * as CountryProvider from 'CountryProvider/countryProvider';
import { Country } from 'CountryProvider/Country';
import * as CityProvider from 'CityProvider/cityProvider';
import { City } from 'CityProvider/City';

export const CountryCities = () => {
  const [countrySelected, setCountrySelected] = useState({} as Country);
  const [countries, setCountries] = useState([] as Country[]);
  const [cities, setCities] = useState([] as City[]);

  useEffect(() => {
    // You need to restrict it at some point
    // This is just dummy code and should be replaced by actual
    
    CountryProvider.getAllCountries().then(res => setCountries(res));
    console.log('Fetching countries');
    
  }, []);

  useEffect(() => {
    
    if (countrySelected.id)
    {
        console.log(`Fetching cities for ${countrySelected.name}`);
        CityProvider.getCitiesByCountry(countrySelected.id).then(res => setCities(res));
    }
    else
    {
        console.log('No country selected');
    }
    
  }, [countrySelected]);


  return (
    <Fragment>
      <Form.Group>
        URL located at {process.env.REACT_APP_API_URL}
      </Form.Group>
      <Form.Group>
        <Form.Label>Select a country</Form.Label>
        <DropdownButton id="dropdown-basic-button" title="Dropdown button">
            {countries.map(country => (
                <Dropdown.Item eventKey="{country.id}" onSelect={() => setCountrySelected(country)}>{country.name}</Dropdown.Item>
            ))}
        </DropdownButton>
      </Form.Group>
      <Form.Group>
        {cities.length === 0 &&
            <Form.Label>No cities in that country</Form.Label>
        }
        {!countrySelected &&
            <Form.Label>No country selected</Form.Label>
        }
        {cities.length > 0 &&
            <Table striped bordered hover>
                <tbody>
                    {cities.map(city => (
                        <tr key={city.id}>
                            <td>{city.name}</td>
                        </tr>
                    ))}
                </tbody>
            </Table>
        }
      </Form.Group>
    </Fragment>
  );
};