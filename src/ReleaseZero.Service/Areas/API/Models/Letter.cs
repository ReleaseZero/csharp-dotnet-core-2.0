using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace ReleaseZero.Service.Areas.API.Models
{
    /// <summary>
    /// Letter object
    /// </summary>
    public class Letter
    {
        private char _character;

        /// <summary>
        /// The letter of the English alphabet. Will be defaulted to lowercase.
        /// </summary>
        /// <value>The letter of the English alphabet</value>
        [Key]
        [Display(Name = "Character")]
        [JsonProperty("character")]
        [RegularExpression(@"^[a-zA-Z]{1}$", ErrorMessage =  "{0} must be a letter")]
        [Required(ErrorMessage = "{0} is required")]
        public char Character { get { return _character; } set { _character = Char.ToLowerInvariant(value); } }

        /// <summary>
        /// The position of the letter in the English alphabet. This must be an integer between 1 and 26 (inclusinve).
        /// </summary>
        /// <value>The position of the letter in the English alphabet</value>
        [Display(Name = "Position")]
        [JsonProperty("position")]
        [Range(1, 26, ErrorMessage = "{0} must be a value between {1} and {2} (inclusive)")]
        [Required(ErrorMessage = "{0} is required")]
        public int Position { get; set; }

        /// <summary>
        /// The telephony value for the letter based on the NATO phonetic alphabet 
        /// </summary>
        /// <value>The telephony value</value>
        [Display(Name = "Telephony")]
        [JsonProperty("telephony")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "The value of '{0}' must be between {2} and {1} characters")]
        public string Telephony { get; set; }

        /// <summary>
        /// The Morse Code representation of the letter
        /// </summary>
        /// <value>The morse code representation of the letter</value>
        [Display(Name = "Morse Code")]
        [JsonProperty("morseCode")]
        [RegularExpression(@"^[·-]{1,4}$", ErrorMessage = "{0} must consist of one to four '·' and '-' characters")]
        [Required(ErrorMessage = "{0} is required")]
        [StringLength(4, MinimumLength = 1, ErrorMessage = "{0} must be between {2} and {1} characters")]
        public string MorseCode { get; set; }
    }
}