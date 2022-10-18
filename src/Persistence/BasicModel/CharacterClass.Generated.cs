// <copyright file="CharacterClass.Generated.cs" company="MUnique">
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
// </copyright>

//------------------------------------------------------------------------------
// <auto-generated>
//     This source code was auto-generated by a roslyn code generator.
// </auto-generated>
//------------------------------------------------------------------------------

// ReSharper disable All

namespace MUnique.OpenMU.Persistence.BasicModel;

using MUnique.OpenMU.Persistence.Json;

/// <summary>
/// A plain implementation of <see cref="CharacterClass"/>.
/// </summary>
public partial class CharacterClass : MUnique.OpenMU.DataModel.Configuration.CharacterClass, IIdentifiable, IConvertibleTo<CharacterClass>
{
    
    /// <summary>
    /// Gets or sets the identifier of this instance.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Gets the raw collection of <see cref="StatAttributes" />.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("statAttributes")]
    [System.Text.Json.Serialization.JsonPropertyName("statAttributes")]
    public ICollection<StatAttributeDefinition> RawStatAttributes { get; } = new List<StatAttributeDefinition>();
    
    /// <inheritdoc/>
    [Newtonsoft.Json.JsonIgnore]
    [System.Text.Json.Serialization.JsonIgnore]
    public override ICollection<MUnique.OpenMU.DataModel.Configuration.StatAttributeDefinition> StatAttributes
    {
        get => base.StatAttributes ??= new CollectionAdapter<MUnique.OpenMU.DataModel.Configuration.StatAttributeDefinition, StatAttributeDefinition>(this.RawStatAttributes);
        protected set
        {
            this.StatAttributes.Clear();
            foreach (var item in value)
            {
                this.StatAttributes.Add(item);
            }
        }
    }

    /// <summary>
    /// Gets the raw collection of <see cref="AttributeCombinations" />.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("attributeCombinations")]
    [System.Text.Json.Serialization.JsonPropertyName("attributeCombinations")]
    public ICollection<AttributeRelationship> RawAttributeCombinations { get; } = new List<AttributeRelationship>();
    
    /// <inheritdoc/>
    [Newtonsoft.Json.JsonIgnore]
    [System.Text.Json.Serialization.JsonIgnore]
    public override ICollection<MUnique.OpenMU.AttributeSystem.AttributeRelationship> AttributeCombinations
    {
        get => base.AttributeCombinations ??= new CollectionAdapter<MUnique.OpenMU.AttributeSystem.AttributeRelationship, AttributeRelationship>(this.RawAttributeCombinations);
        protected set
        {
            this.AttributeCombinations.Clear();
            foreach (var item in value)
            {
                this.AttributeCombinations.Add(item);
            }
        }
    }

    /// <summary>
    /// Gets the raw collection of <see cref="BaseAttributeValues" />.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("baseAttributeValues")]
    [System.Text.Json.Serialization.JsonPropertyName("baseAttributeValues")]
    public ICollection<ConstValueAttribute> RawBaseAttributeValues { get; } = new List<ConstValueAttribute>();
    
    /// <inheritdoc/>
    [Newtonsoft.Json.JsonIgnore]
    [System.Text.Json.Serialization.JsonIgnore]
    public override ICollection<MUnique.OpenMU.AttributeSystem.ConstValueAttribute> BaseAttributeValues
    {
        get => base.BaseAttributeValues ??= new CollectionAdapter<MUnique.OpenMU.AttributeSystem.ConstValueAttribute, ConstValueAttribute>(this.RawBaseAttributeValues);
        protected set
        {
            this.BaseAttributeValues.Clear();
            foreach (var item in value)
            {
                this.BaseAttributeValues.Add(item);
            }
        }
    }

    /// <summary>
    /// Gets the raw object of <see cref="NextGenerationClass" />.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("nextGenerationClass")]
    [System.Text.Json.Serialization.JsonPropertyName("nextGenerationClass")]
    public CharacterClass RawNextGenerationClass
    {
        get => base.NextGenerationClass as CharacterClass;
        set => base.NextGenerationClass = value;
    }

    /// <inheritdoc/>
    [Newtonsoft.Json.JsonIgnore]
    [System.Text.Json.Serialization.JsonIgnore]
    public override MUnique.OpenMU.DataModel.Configuration.CharacterClass NextGenerationClass
    {
        get => base.NextGenerationClass;
        set => base.NextGenerationClass = value;
    }

    /// <summary>
    /// Gets the raw object of <see cref="HomeMap" />.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("homeMap")]
    [System.Text.Json.Serialization.JsonPropertyName("homeMap")]
    public GameMapDefinition RawHomeMap
    {
        get => base.HomeMap as GameMapDefinition;
        set => base.HomeMap = value;
    }

    /// <inheritdoc/>
    [Newtonsoft.Json.JsonIgnore]
    [System.Text.Json.Serialization.JsonIgnore]
    public override MUnique.OpenMU.DataModel.Configuration.GameMapDefinition HomeMap
    {
        get => base.HomeMap;
        set => base.HomeMap = value;
    }

    /// <summary>
    /// Gets the raw object of <see cref="ComboDefinition" />.
    /// </summary>
    [Newtonsoft.Json.JsonProperty("comboDefinition")]
    [System.Text.Json.Serialization.JsonPropertyName("comboDefinition")]
    public SkillComboDefinition RawComboDefinition
    {
        get => base.ComboDefinition as SkillComboDefinition;
        set => base.ComboDefinition = value;
    }

    /// <inheritdoc/>
    [Newtonsoft.Json.JsonIgnore]
    [System.Text.Json.Serialization.JsonIgnore]
    public override MUnique.OpenMU.DataModel.Configuration.SkillComboDefinition ComboDefinition
    {
        get => base.ComboDefinition;
        set => base.ComboDefinition = value;
    }


    /// <inheritdoc/>
    public override bool Equals(object obj)
    {
        var baseObject = obj as IIdentifiable;
        if (baseObject != null)
        {
            return baseObject.Id == this.Id;
        }

        return base.Equals(obj);
    }

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        return this.Id.GetHashCode();
    }

    /// <inheritdoc/>
    public CharacterClass Convert() => this;
}
