# Locating a city using geocode API

import requests
import os
import folium 
from geopy import Nominatim as NT


geo_locator = NT(user_agent="geoapiExercises")

place = "London"
location = geo_locator.geocode(place)

user_map = folium.Map(location=[location.latitude, location.longitude])

folium.Marker([location.latitude, location.longitude],popup = ['London']).add_to(user_map)

user_map.show_in_browser()
