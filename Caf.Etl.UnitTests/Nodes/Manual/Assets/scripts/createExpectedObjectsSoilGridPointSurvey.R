library(tidyverse)

setwd("C:/Dev/Caf/Etl/Caf.Etl.UnitTests/Nodes/Manual/Assets")

df <- read_csv("soilCore1998To2015ShallowDeepMergedByHorizon_20180925_slim.csv")
dict <- read_csv("soilCore1998To2015ShallowDeepMergedByHorizon_Dictionary_20180925.csv")

# print SoilGridPointSurveyV1 code
soilGridPointSurveyV1 <- paste("public ", str_to_lower(dict$DataType), " ", dict$FieldNames, " { get; set; }", sep = "")
writeLines(soilGridPointSurveyV1, "scripts/soilGridPointSurveyV1Code.txt")

# print HardHarvestYieldV1 expected data for unit tests
#df0 <- df %>% 
#  mutate_if(is.numeric, replace_na, "null") %>% 
#  mutate_if(is_character, replace_na, "null")
#
#getObservationsDerivedFromActualDataV1 <- paste(
#  "new HandHarvestYieldV1() { ",
#  "HarvestYear = ", df0$HarvestYear, ", ",
#  "Crop = ", ifelse(df0$Crop == "null", df0$Crop, paste("\"", df0$Crop, "\"", sep = "")), ", ",
#  "SampleID = ", ifelse(df0$SampleID == "null", df0$SampleID, paste("\"", df0$SampleID, "\"", sep = "")), ", ",
#  "Latitude = ", df0$Latitude, ", ",
#  "Longitude = ", df0$Longitude, ", ",
#  "ID2 = ", df0$ID2, ", ",
#  "GrainWeight = ", df0$GrainWeight, ", ",
#  "Area = ", df0$Area, ", ",
#  "Yield_g_m2 = ", df0$Yield_g_m2, ", ",
#  "Yield_lb_ac = ", df0$Yield_lb_ac, ", ",
#  "Yield_bu_ac = ", df0$Yield_bu_ac, ", ",
#  "TestWeight = ", df0$TestWeight, ", ",
#  "OilDM = ", df0$OilDM, ", ",
#  "Protein = ", df0$Protein, ", ",
#  "Moisture = ", df0$Moisture, ", ",
#  "Starch = ", df0$Starch, ", ",
#  "WGlutDM = ", df0$WGlutDM, ", ",
#  "Notes = ", ifelse(df0$Notes == "null", df0$Notes, paste("\"", df0$Notes, "\"", sep = "")), " ",
#  "},",
#  sep = ""
#)
#write_lines(getObservationsDerivedFromActualDataV1, "scripts/getObservationDerivedFromActualDataV1Code.txt")