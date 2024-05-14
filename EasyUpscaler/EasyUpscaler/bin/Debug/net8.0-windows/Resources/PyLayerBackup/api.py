import os
import sys
import json
from utils.upscaler import Upscaler

with open("./data1.json", "r") as json_file:
    data = json.load(json_file)

modelPath = data["modelPath"]
inputFolder = data["inputFolder"]
outputFolder = data["outputFolder"]
tileSize = data["tileSize"]


upscaler = Upscaler(modelPath, inputFolder, outputFolder, tileSize, "png")

upscaler.run()
