# <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleText"></a> Class CUserMsg\_ParticleManager.Types.SetParticleText

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CUserMsg_ParticleManager.Types.SetParticleText : IMessage<CUserMsg_ParticleManager.Types.SetParticleText>, IEquatable<CUserMsg_ParticleManager.Types.SetParticleText>, IDeepCloneable<CUserMsg_ParticleManager.Types.SetParticleText>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CUserMsg\_ParticleManager.Types.SetParticleText](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleText.md)

#### Implements

IMessage<CUserMsg\_ParticleManager.Types.SetParticleText\>, 
[IEquatable<CUserMsg\_ParticleManager.Types.SetParticleText\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CUserMsg\_ParticleManager.Types.SetParticleText\>, 
IBufferMessage, 
IMessage

#### Inherited Members

[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode)

#### Extension Methods

[ObjectExtensions.Dump\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_Dump\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToConsole\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToConsole\_System\_Object\_System\_Boolean\_), 
[ObjectExtensions.DumpToLogDebug\(object?, bool\)](Divine.Extensions.ObjectExtensions.md\#Divine\_Extensions\_ObjectExtensions\_DumpToLogDebug\_System\_Object\_System\_Boolean\_), 
[EnumerableExtensions.In<CUserMsg\_ParticleManager.Types.SetParticleText\>\(CUserMsg\_ParticleManager.Types.SetParticleText, params CUserMsg\_ParticleManager.Types.SetParticleText\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleText__ctor"></a> SetParticleText\(\)

```csharp
public SetParticleText()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleText__ctor_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleText_"></a> SetParticleText\(SetParticleText\)

```csharp
public SetParticleText(CUserMsg_ParticleManager.Types.SetParticleText other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetParticleText](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleText.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleText_LocalizeFieldNumber"></a> LocalizeFieldNumber

```csharp
public const int LocalizeFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleText_TextFieldNumber"></a> TextFieldNumber

```csharp
public const int TextFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleText_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleText_HasLocalize"></a> HasLocalize

```csharp
public bool HasLocalize { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleText_HasText"></a> HasText

```csharp
public bool HasText { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleText_Localize"></a> Localize

```csharp
public bool Localize { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleText_Parser"></a> Parser

```csharp
public static MessageParser<CUserMsg_ParticleManager.Types.SetParticleText> Parser { get; }
```

#### Property Value

 MessageParser<[CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetParticleText](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleText.md)\>

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleText_Text"></a> Text

```csharp
public string Text { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleText_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleText_ClearLocalize"></a> ClearLocalize\(\)

```csharp
public void ClearLocalize()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleText_ClearText"></a> ClearText\(\)

```csharp
public void ClearText()
```

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleText_Clone"></a> Clone\(\)

```csharp
public CUserMsg_ParticleManager.Types.SetParticleText Clone()
```

#### Returns

 [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetParticleText](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleText.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleText_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleText_Equals_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleText_"></a> Equals\(SetParticleText\)

```csharp
public bool Equals(CUserMsg_ParticleManager.Types.SetParticleText other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetParticleText](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleText.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleText_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleText_MergeFrom_Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleText_"></a> MergeFrom\(SetParticleText\)

```csharp
public void MergeFrom(CUserMsg_ParticleManager.Types.SetParticleText other)
```

#### Parameters

`other` [CUserMsg\_ParticleManager](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.md).[Types](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.md).[SetParticleText](Divine.Protobufs.Dota2.CUserMsg\_ParticleManager.Types.SetParticleText.md)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleText_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleText_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CUserMsg_ParticleManager_Types_SetParticleText_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

