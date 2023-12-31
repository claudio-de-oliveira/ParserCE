﻿using JsonElement;

using System.Text.Json.Nodes;

namespace TestParser
{
    internal class Variables
    {
        private static string text = @"
{
    ""status"": ""OK"",
    ""message"": null,
    ""data"": {
        ""questionnaireJSON"": {
            ""Variables"": {
                ""TravelClass"": {
                    ""InputMethod"": ""ButtonList"",
                    ""Name"": ""TravelClass"",
                    ""DataType"": ""String"",
                    ""FieldOnly"": ""true"",
                    ""OccursOrder"": ""7"",
                    ""Prompt"": ""Please select the travel class"",
                    ""Selections"": [
                        ""NowCM First"",
                        ""NowCM Business"",
                        ""Coach""
                    ],
                    ""Logic"": ""true"",
                    ""OriginalPrompt"": ""Please select the travel class"",
                    ""Relevant"": false,
                    ""Visible"": true,
                    ""Value"": ""NowCM Business""
                },
                ""PassengerName"": {
                    ""Name"": ""PassengerName"",
                    ""DataType"": ""String"",
                    ""FieldOnly"": ""true"",
                    ""OccursOrder"": ""1"",
                    ""Prompt"": ""Enter the name of the lead passenger"",
                    ""Logic"": ""true"",
                    ""OriginalPrompt"": ""Enter the name of the lead passenger"",
                    ""Relevant"": false,
                    ""Visible"": true,
                    ""Value"": ""Luisa""
                },
                ""PassengerAddress"": {
                    ""Depth"": ""6"",
                    ""Name"": ""PassengerAddress"",
                    ""DataType"": ""String"",
                    ""FieldOnly"": ""true"",
                    ""OccursOrder"": ""4"",
                    ""Prompt"": ""Enter the addresss of the lead passenger"",
                    ""Logic"": ""true"",
                    ""OriginalPrompt"": ""Enter the addresss of the lead passenger"",
                    ""Relevant"": false,
                    ""Visible"": true,
                    ""Value"": ""test""
                },
                ""PassengerPassport"": {
                    ""Name"": ""PassengerPassport"",
                    ""DataType"": ""String"",
                    ""FieldOnly"": ""true"",
                    ""OccursOrder"": ""2"",
                    ""Prompt"": ""Enter the passport number of the lead passenger"",
                    ""Logic"": ""true"",
                    ""OriginalPrompt"": ""Enter the passport number of the lead passenger"",
                    ""Relevant"": false,
                    ""Visible"": true,
                    ""Value"": ""abc123""
                },
                ""Luggage"": {
                    ""InputMethod"": ""ButtonList"",
                    ""Name"": ""Luggage"",
                    ""DataType"": ""Boolean"",
                    ""FieldOnly"": ""true"",
                    ""OccursOrder"": ""8"",
                    ""Prompt"": ""Will the passenger be checking in any luggage?"",
                    ""Selections"": [
                        ""Checked luggage"",
                        ""Hand Luggage only""
                    ],
                    ""Logic"": ""true"",
                    ""OriginalPrompt"": ""Will the passenger be checking in any luggage?"",
                    ""Relevant"": false,
                    ""SelectionValues"": [
                        true,
                        false
                    ],
                    ""Visible"": true,
                    ""Value"": true
                },
                ""TravelDate"": {
                    ""InputMethod"": ""Calendar"",
                    ""Name"": ""TravelDate"",
                    ""DataType"": ""Date"",
                    ""FieldOnly"": ""true"",
                    ""OccursOrder"": ""9"",
                    ""Prompt"": ""Select the date of travel"",
                    ""DefaultFormat"": ""mm/dd/yyyy"",
                    ""Logic"": ""true"",
                    ""OriginalPrompt"": ""Select the date of travel"",
                    ""Relevant"": false,
                    ""Visible"": true,
                    ""Value"": ""2023-09-29""
                },
                ""DepartureAirport"": {
                    ""OtherOption"": ""true"",
                    ""InputMethod"": ""ButtonList"",
                    ""Name"": ""DepartureAirport"",
                    ""DataType"": ""String"",
                    ""FieldOnly"": ""true"",
                    ""OccursOrder"": ""3"",
                    ""Prompt"": ""Select the departure Airport"",
                    ""Selections"": [
                        ""France, Paris - CDG"",
                        ""Luxembourg - LUX"",
                        ""Spain, Madrid - MAD"",
                        ""Austria, Vienna - VIE"",
                        ""Germany, Berlin - BER"",
                        ""UK, London - LCY"",
                        ""UK, London - LHR""
                    ],
                    ""Logic"": ""true"",
                    ""OriginalPrompt"": ""Select the departure Airport"",
                    ""Relevant"": true,
                    ""Visible"": true,
                    ""Value"": ""France, Paris - CDG""
                },
                ""ArrivalAirport"": {
                    ""OtherOption"": ""true"",
                    ""InputMethod"": ""ButtonList"",
                    ""Name"": ""ArrivalAirport"",
                    ""DataType"": ""String"",
                    ""FieldOnly"": ""true"",
                    ""OccursOrder"": ""6"",
                    ""Prompt"": ""Select the destination airport"",
                    ""Selections"": [
                        ""France, Paris - CDG"",
                        ""Luxembourg - LUX"",
                        ""Spain, Madrid - MAD"",
                        ""Austria, Vienna - VIE"",
                        ""Germany, Berlin - BER"",
                        ""UK, London - LCY"",
                        ""UK, London - LHR""
                    ],
                    ""Logic"": ""true"",
                    ""OriginalPrompt"": ""Select the destination airport"",
                    ""Relevant"": true,
                    ""Visible"": true,
                    ""Value"": ""NY""
                },
                ""AddPass"": {
                    ""Name"": ""AddPass"",
                    ""DataType"": ""String"",
                    ""FieldOnly"": ""true"",
                    ""OccursOrder"": ""18"",
                    ""Prompt"": [
                        ""Enter the name of the additional passenger"",
                        ""Enter the name of the additional passenger""
                    ],
                    ""Repeat"": [
                        ""Repeat 1 to PassengerNumber""
                    ],
                    ""Logic"": ""UnRepeated(AddPassYN)"",
                    ""OriginalPrompt"": ""Enter the name of the additional passenger"",
                    ""Relevant"": false,
                    ""Visible"": [
                        true,
                        true
                    ],
                    ""Repeats"": 2,
                    ""Value"": [
                        ""Lucas"",
                        ""Ana""
                    ]
                },
                ""Seat"": {
                    ""InputMethod"": ""ButtonList"",
                    ""Name"": ""Seat"",
                    ""DataType"": ""String"",
                    ""FieldOnly"": ""true"",
                    ""OccursOrder"": ""5"",
                    ""Prompt"": ""Please select your preferred seat"",
                    ""Selections"": [
                        ""Aisle"",
                        ""Window""
                    ],
                    ""Logic"": ""true"",
                    ""OriginalPrompt"": ""Please select your preferred seat"",
                    ""Relevant"": false,
                    ""Visible"": true,
                    ""Value"": ""Aisle""
                },
                ""PassengerNumber"": {
                    ""InputMethod"": ""GroupRepeat"",
                    ""Name"": ""PassengerNumber"",
                    ""DataType"": ""Integer"",
                    ""OccursOrder"": ""11"",
                    ""Prompt"": ""How many passengers is this booking for?"",
                    ""DefaultFormat"": ""wordslow"",
                    ""Logic"": ""true"",
                    ""OriginalPrompt"": ""How many passengers is this booking for?"",
                    ""Relevant"": true,
                    ""RepeatOnDemandGroups"": [
                        ""Additional Passengers""
                    ],
                    ""Visible"": true,
                    ""Value"": 2
                },
                ""Meal"": {
                    ""InputMethod"": ""SelectList"",
                    ""Name"": ""Meal"",
                    ""DataType"": ""String"",
                    ""FieldOnly"": ""true"",
                    ""OccursOrder"": ""12"",
                    ""Prompt"": ""Select meal requirements"",
                    ""Selections"": [
                        ""Regular Meal"",
                        ""Vegetarian"",
                        ""Vegan"",
                        ""Halal"",
                        ""Kosher"",
                        ""No meal requirement""
                    ],
                    ""Logic"": ""true"",
                    ""OriginalPrompt"": ""Select meal requirements"",
                    ""Relevant"": false,
                    ""Visible"": true,
                    ""Value"": ""Halal""
                },
                ""PassengerType"": {
                    ""InputMethod"": ""ButtonList"",
                    ""Name"": ""PassengerType"",
                    ""DataType"": ""String"",
                    ""FieldOnly"": ""true"",
                    ""OccursOrder"": ""22"",
                    ""Prompt"": [""Is this passenger an Adult or a Child"",""Is this passenger an Adult or a Child""],
                    ""Guidance"": ""Adult is any passenger over the age of 16"",
                    ""Selections"": [""Adult"", ""Child""],
                    ""Repeat"": [
                        ""Repeat 1 to PassengerNumber""
                    ],
                    ""Logic"": ""UnRepeated(AddPassYN)"",
                    ""OriginalPrompt"": ""Is this passenger an Adult or a Child"",
                    ""Relevant"": false,
                    ""Visible"": [true, true],
                    ""Repeats"": 2,
                    ""Value"": [""Adult"", ""Child""]
                },
                ""TravelTme"": {
                    ""InputMethod"": ""Clock"",
                    ""Name"": ""TravelTme"",
                    ""DataType"": ""Time"",
                    ""FieldOnly"": ""true"",
                    ""OccursOrder"": ""13"",
                    ""Prompt"": ""Select the time of travel"",
                    ""DefaultFormat"": ""hh24:mm"",
                    ""Logic"": ""true"",
                    ""OriginalPrompt"": ""Select the time of travel"",
                    ""Relevant"": false,
                    ""Visible"": true,
                    ""Value"": ""17:07""
                },
                ""AddPassengerPassport"": {
                    ""Name"": ""AddPassengerPassport"",
                    ""DataType"": ""String"",
                    ""FieldOnly"": ""true"",
                    ""OccursOrder"": ""19"",
                    ""Prompt"": [
                        ""Enter the passport number of the additional passenger"",
                        ""Enter the passport number of the additional passenger""
                    ],
                    ""Repeat"": [
                        ""Repeat 1 to PassengerNumber""
                    ],
                    ""Logic"": ""UnRepeated(AddPassYN)"",
                    ""OriginalPrompt"": ""Enter the passport number of the additional passenger"",
                    ""Relevant"": false,
                    ""Visible"": [
                        true,
                        true
                    ],
                    ""Repeats"": 2,
                    ""Value"": [
                        ""YYYYYYYYY"",
                        ""1111""
                    ]
                },
                ""AddSeat"": {
                    ""InputMethod"": ""ButtonList"",
                    ""Name"": ""AddSeat"",
                    ""DataType"": ""String"",
                    ""FieldOnly"": ""true"",
                    ""OccursOrder"": ""20"",
                    ""Prompt"": [
                        ""Please select the preferred seat"",
                        ""Please select the preferred seat""
                    ],
                    ""Selections"": [
                        ""Aisle"",
                        ""Window""
                    ],
                    ""Repeat"": [
                        ""Repeat 1 to PassengerNumber""
                    ],
                    ""Logic"": ""UnRepeated(AddPassYN)"",
                    ""OriginalPrompt"": ""Please select the preferred seat"",
                    ""Relevant"": false,
                    ""Visible"": [
                        true,
                        true
                    ],
                    ""Repeats"": 2,
                    ""Value"": [
                        ""Window"",
                        ""Aisle""
                    ]
                },
                ""AddMeal"": {
                    ""InputMethod"": ""SelectList"",
                    ""Name"": ""AddMeal"",
                    ""DataType"": ""String"",
                    ""FieldOnly"": ""true"",
                    ""OccursOrder"": ""23"",
                    ""Prompt"": [
                        ""Select meal requirements"",
                        ""Select meal requirements""
                    ],
                    ""Selections"": [
                        ""Regular Meal"",
                        ""Vegetarian"",
                        ""Vegan"",
                        ""Halal"",
                        ""Kosher"",
                        ""No meal requirement""
                    ],
                    ""Repeat"": [
                        ""Repeat 1 to PassengerNumber""
                    ],
                    ""Logic"": ""UnRepeated(AddPassYN)"",
                    ""OriginalPrompt"": ""Select meal requirements"",
                    ""Relevant"": false,
                    ""Visible"": [
                        true,
                        true
                    ],
                    ""Repeats"": 2,
                    ""Value"": [
                        ""Vegan"",
                        ""Vegetarian""
                    ]
                },
                ""AddLuggage"": {
                    ""InputMethod"": ""ButtonList"",
                    ""Name"": ""AddLuggage"",
                    ""DataType"": ""Boolean"",
                    ""FieldOnly"": ""true"",
                    ""OccursOrder"": ""21"",
                    ""Prompt"": [
                        ""Will the passenger be checking in any luggage?"",
                        ""Will the passenger be checking in any luggage?""
                    ],
                    ""Selections"": [
                        ""Checked luggage"",
                        ""Hand Luggage only""
                    ],
                    ""Repeat"": [
                        ""Repeat 1 to PassengerNumber""
                    ],
                    ""Logic"": ""UnRepeated(AddPassYN)"",
                    ""OriginalPrompt"": ""Will the passenger be checking in any luggage?"",
                    ""Relevant"": false,
                    ""SelectionValues"": [
                        true,
                        false
                    ],
                    ""Visible"": [
                        true,
                        true
                    ],
                    ""Repeats"": 2,
                    ""Value"": [
                        ""false"",
                        ""true""
                    ]
                },
                ""TransactionTitle"": {
                    ""Name"": ""TransactionTitle"",
                    ""Computable"": ""true"",
                    ""DataType"": ""String"",
                    ""FieldOnly"": ""true"",
                    ""OccursOrder"": ""24"",
                    ""Definition"": ""\""Flight_Details_\""+ifknownelse(PassengerName,\""[●]\"")+\""_\""+Ifknownelse((tostring(TravelDate)),\""[●]\"")+\""_\""+Ifknownelse((tostring(TravelTme)),\""[●]\"")+\""_\""+ifknownelse(PassengerPassport,\""[●]\"")"",
                    ""Prompt"": [
                        ""TransactionTitle"",
                        ""TransactionTitle""
                    ],
                    ""Logic"": true,
                    ""OriginalPrompt"": ""TransactionTitle"",
                    ""Value"": ""Flight_Details_Luisa_2023-09-29_17:07_abc123"",
                    ""Relevant"": false,
                    ""Visible"": [
                        false,
                        false
                    ],
                    ""Repeat"": ""true"",
                    ""Repeats"": 2
                },
                ""PasssengerTotal"": {
                    ""Name"": ""PasssengerTotal"",
                    ""Computable"": ""true"",
                    ""DataType"": ""Integer"",
                    ""FieldOnly"": ""true"",
                    ""OccursOrder"": ""10"",
                    ""Definition"": ""(PassengerNumber)+1"",
                    ""Prompt"": ""PasssengerTotal"",
                    ""DefaultFormat"": ""wordslow"",
                    ""Logic"": true,
                    ""OriginalPrompt"": ""PasssengerTotal"",
                    ""Relevant"": false,
                    ""Visible"": false,
                    ""Value"": 3
                },
                ""AddPassYN"": {
                    ""InputMethod"": ""ButtonList"",
                    ""Name"": ""AddPassYN"",
                    ""DataType"": ""Boolean"",
                    ""OccursOrder"": ""17"",
                    ""Prompt"": ""Apart from the lead passenger, are there any additional passengers?"",
                    ""Logic"": ""true"",
                    ""OriginalPrompt"": ""Apart from the lead passenger, are there any additional passengers?"",
                    ""Relevant"": true,
                    ""Selections"": [
                        ""Yes"",
                        ""No""
                    ],
                    ""SelectionValues"": [
                        true,
                        false
                    ],
                    ""Visible"": true,
                    ""Value"": true
                },
                ""ReturnTravelDate"": {
                    ""InputMethod"": ""Calendar"",
                    ""Name"": ""ReturnTravelDate"",
                    ""DataType"": ""Date"",
                    ""FieldOnly"": ""true"",
                    ""OccursOrder"": ""15"",
                    ""Prompt"": ""Select the date of return travel"",
                    ""DefaultFormat"": ""mm/dd/yyyy"",
                    ""Logic"": ""SingleReturn is \""Return\"""",
                    ""OriginalPrompt"": ""Select the date of return travel"",
                    ""Relevant"": false,
                    ""Visible"": true,
                    ""Value"": ""2023-09-28""
                },
                ""ReturnTravelTme"": {
                    ""InputMethod"": ""Clock"",
                    ""Name"": ""ReturnTravelTme"",
                    ""DataType"": ""Time"",
                    ""FieldOnly"": ""true"",
                    ""OccursOrder"": ""16"",
                    ""Prompt"": ""Select the time of return travel"",
                    ""DefaultFormat"": ""hh24:mm"",
                    ""Logic"": ""SingleReturn is \""Return\"""",
                    ""OriginalPrompt"": ""Select the time of return travel"",
                    ""Relevant"": false,
                    ""Visible"": true,
                    ""Value"": ""17:07""
                },
                ""SingleReturn"": {
                    ""InputMethod"": ""ButtonList"",
                    ""Name"": ""SingleReturn"",
                    ""DataType"": ""String"",
                    ""OccursOrder"": ""14"",
                    ""Prompt"": ""Is this a booking for a single flight or a return flight"",
                    ""Selections"": [
                        ""Single"",
                        ""Return""
                    ],
                    ""Logic"": ""true"",
                    ""OriginalPrompt"": ""Is this a booking for a single flight or a return flight"",
                    ""Relevant"": true,
                    ""Visible"": true,
                    ""Value"": ""Return""
                },
                ""VARIABLE_CHANGED"": {
                    ""Name"": ""VARIABLE_CHANGED"",
                    ""Value"": [
                        ""AddPassYN"",
                        ""SingleReturn"",
                        ""DepartureAirport"",
                        ""ArrivalAirport"",
                        ""DepartureAirport"",
                        ""ArrivalAirport"",
                        ""PassengerNumber"",
                        ""AddPassYN"",
                        ""SingleReturn""
                    ],
                    ""Visible"": true
                }
            },
            ""Questionnaires"": {
                ""Flight Bookings for NowCM Air"": {
                    ""Name"": ""Flight Bookings for NowCM Air"",
                    ""Group"": [
                        {
                            ""Name"": ""Flight and group size details"",
                            ""Variables"": [
                                ""AddPassYN"",
                                ""SingleReturn"",
                                ""DepartureAirport"",
                                ""ArrivalAirport"",
                                ""TravelDate"",
                                ""TravelTme"",
                                ""ReturnTravelTme"",
                                ""ReturnTravelDate"",
                                ""TravelClass""
                            ],
                            ""RepeatOnDemand"": false,
                            ""Visible"": true
                        },
                        {
                            ""Name"": ""Lead Passenger"",
                            ""Variables"": [
                                ""PassengerName"",
                                ""PassengerAddress"",
                                ""PassengerPassport"",
                                ""Luggage"",
                                ""Meal"",
                                ""Seat""
                            ],
                            ""RepeatOnDemand"": false,
                            ""Visible"": true
                        },
                        {
                            ""Name"": ""Additional Passengers"",
                            ""Variables"": [
                                ""AddPass"",
                                ""PassengerType"",
                                ""AddPassengerPassport"",
                                ""AddSeat"",
                                ""AddMeal"",
                                ""AddLuggage"",
                                ""TransactionTitle""
                            ],
                            ""RepeatOnDemand"": true,
                            ""Repeat"": [
                                ""Repeat 1 to PassengerNumber""
                            ],
                            ""Logic"": ""UnRepeated(AddPassYN)"",
                            ""RepeatOnDemandVariables"": [
                                ""PassengerNumber""
                            ],
                            ""Repeats"": 2,
                            ""Visible"": true
                        }
                    ],
                    ""Visible"": true
                }
            },
            ""Alerts"": [
                {
                    ""Compulsory"": true,
                    ""Definition"": ""DepartureAirport is \""France, Paris - CDG\"" and ArrivalAirport is \""France, Paris - CDG\"" or DepartureAirport is \""Luxembourg - LUX\"" and ArrivalAirport is \""Luxembourg - LUX\"" or DepartureAirport is \""Spain, Madrid - MAD\"" and ArrivalAirport is \""Spain, Madrid - MAD\"" or DepartureAirport is \""Austria, Vienna - VIE\"" and ArrivalAirport is \""Austria, Vienna - VIE\"" or DepartureAirport is \""Germany, Berlin - BER\"" and ArrivalAirport is \""Germany, Berlin - BER\"" or DepartureAirport is \""UK, London - LCY\"" and ArrivalAirport is \""UK, London - LCY\"" or DepartureAirport is \""UK, London - LHR\"" and ArrivalAirport is \""UK, London - LHR\"""",
                    ""Message"": ""NOTICE: Your departure and destination airports can not be the same, please reselect to progress through the booking process"",
                    ""Visible"": false,
                    ""Variables"": [
                        ""DepartureAirport"",
                        ""ArrivalAirport""
                    ]
                }
            ],
            ""Lookups"": {},
            ""Functions"": {},
            ""ListenFor"": {
                ""AddPassYN"": {
                    ""Variable"": [
                        ""AddPass"",
                        ""PassengerType"",
                        ""AddPassengerPassport"",
                        ""AddSeat"",
                        ""AddMeal"",
                        ""AddLuggage""
                    ],
                    ""Questionnaire"": {
                        ""Flight Bookings for NowCM Air"": [
                            ""Additional Passengers""
                        ]
                    }
                },
                ""PassengerNumber"": {
                    ""Variable"": [
                        ""AddPass"",
                        ""PassengerType"",
                        ""AddPassengerPassport"",
                        ""AddSeat"",
                        ""AddMeal"",
                        ""AddLuggage""
                    ],
                    ""Group"": {
                        ""Flight Bookings for NowCM Air"": [
                            ""Additional Passengers""
                        ]
                    },
                    ""Questionnaire"": {
                        ""Flight Bookings for NowCM Air"": [
                            ""Additional Passengers""
                        ]
                    }
                },
                ""SingleReturn"": {
                    ""Variable"": [
                        ""ReturnTravelDate"",
                        ""ReturnTravelTme""
                    ]
                },
                ""DepartureAirport"": {
                    ""Alert"": [
                        0
                    ]
                },
                ""ArrivalAirport"": {
                    ""Alert"": [
                        0
                    ]
                }
            },
            ""SubTemplate"": {},
            ""ChildTemplate"": [],
            ""MultipleVariables"": [],
            ""SubTemplateLogics"": {},
            ""TemplateReference"": ""Flight_Confirmation""
        },
        ""answers"": null,
        ""jsonMatcher"": null,
        ""idRedis"": ""b7a3a604-a827-494c-b57a-0ab3212942ea""
    }
}
";

        public static Dictionary<string, ConcreteLL.Data.Variable> GetVariables()
        {
            JsonNode json = JsonNode.Parse(text)!;
            Response? _response = Response.Create(json);

            Dictionary<string, ConcreteLL.Data.Variable> variables = new();
            foreach (var key in _response!.Data!.QuestionnaireJSON!.Variables.Dictionary.Keys)
                variables.Add(key, ConvertToLLVariable(_response.Data.QuestionnaireJSON.Variables.Dictionary[key]));

            return variables;
        }


        private static ConcreteLL.Data.Variable ConvertToLLVariable(Variable variable)
            => new()
            {
                InputMethod = variable.InputMethod,
                Name = variable.Name,
                DataType = variable.DataType,
                FieldOnly = variable.FieldOnly,
                OccursOrder = variable.OccursOrder,
                Prompt = variable.Prompt,
                Selections = variable.Selections,
                Repeat = variable.Repeat,
                Repeats = variable.Repeats,
                Definition = variable.Definition,
                Logic = variable.Logic,
                DefaultFormat = variable.DefaultFormat,
                OriginalPrompt = variable.OriginalPrompt,
                Depth = variable.Depth,
                Relevant = variable.Relevant,
                Visible = variable.Visible,
                Value = variable.Value,
            };
    }
}
