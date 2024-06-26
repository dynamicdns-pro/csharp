/*
 * Dynamicdns.pro
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.0.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = dynamicdns.api.Client.OpenAPIDateConverter;
using System.Reflection;

namespace dynamicdns.api.Model
{
    /// <summary>
    /// Updateip200Response
    /// </summary>
    [JsonConverter(typeof(Updateip200ResponseJsonConverter))]
    [DataContract(Name = "updateip_200_response")]
    internal partial class Updateip200Response : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Updateip200Response" /> class
        /// with the <see cref="Updateip200ResponseAnyOf" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of Updateip200ResponseAnyOf.</param>
        public Updateip200Response(Updateip200ResponseAnyOf actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Updateip200Response" /> class
        /// with the <see cref="string" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of string.</param>
        public Updateip200Response(string actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "anyOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(Updateip200ResponseAnyOf))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(string))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: Updateip200ResponseAnyOf, string");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `Updateip200ResponseAnyOf`. If the actual instance is not `Updateip200ResponseAnyOf`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of Updateip200ResponseAnyOf</returns>
        public Updateip200ResponseAnyOf GetUpdateip200ResponseAnyOf()
        {
            return (Updateip200ResponseAnyOf)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `string`. If the actual instance is not `string`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of string</returns>
        public string GetString()
        {
            return (string)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Updateip200Response {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, Updateip200Response.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of Updateip200Response
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of Updateip200Response</returns>
        public static Updateip200Response FromJson(string jsonString)
        {
            Updateip200Response newUpdateip200Response = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newUpdateip200Response;
            }

            try
            {
                newUpdateip200Response = new Updateip200Response(JsonConvert.DeserializeObject<Updateip200ResponseAnyOf>(jsonString, Updateip200Response.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newUpdateip200Response;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into Updateip200ResponseAnyOf: {1}", jsonString, exception.ToString()));
            }

            try
            {
                newUpdateip200Response = new Updateip200Response(JsonConvert.DeserializeObject<string>(jsonString, Updateip200Response.SerializerSettings));
                // deserialization is considered successful at this point if no exception has been thrown.
                return newUpdateip200Response;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into string: {1}", jsonString, exception.ToString()));
            }

            // no match found, throw an exception
            throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for Updateip200Response
    /// </summary>
    public class Updateip200ResponseJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(Updateip200Response).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch(reader.TokenType) 
            {
                case JsonToken.String: 
                    return new Updateip200Response(Convert.ToString(reader.Value));
                case JsonToken.StartObject:
                    return Updateip200Response.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return Updateip200Response.FromJson(JArray.Load(reader).ToString(Formatting.None));
                default:
                    return null;
            }
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
