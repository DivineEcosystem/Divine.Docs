# <a id="Divine_Protobufs_Dota2_CMsg_CVars_Types_CVar"></a> Class CMsg\_CVars.Types.CVar

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsg_CVars.Types.CVar : IMessage<CMsg_CVars.Types.CVar>, IEquatable<CMsg_CVars.Types.CVar>, IDeepCloneable<CMsg_CVars.Types.CVar>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsg\_CVars.Types.CVar](Divine.Protobufs.Dota2.CMsg\_CVars.Types.CVar.md)

#### Implements

IMessage<CMsg\_CVars.Types.CVar\>, 
[IEquatable<CMsg\_CVars.Types.CVar\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsg\_CVars.Types.CVar\>, 
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
[EnumerableExtensions.In<CMsg\_CVars.Types.CVar\>\(CMsg\_CVars.Types.CVar, params CMsg\_CVars.Types.CVar\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_Types_CVar__ctor"></a> CVar\(\)

```csharp
public CVar()
```

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_Types_CVar__ctor_Divine_Protobufs_Dota2_CMsg_CVars_Types_CVar_"></a> CVar\(CVar\)

```csharp
public CVar(CMsg_CVars.Types.CVar other)
```

#### Parameters

`other` [CMsg\_CVars](Divine.Protobufs.Dota2.CMsg\_CVars.md).[Types](Divine.Protobufs.Dota2.CMsg\_CVars.Types.md).[CVar](Divine.Protobufs.Dota2.CMsg\_CVars.Types.CVar.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_Types_CVar_NameFieldNumber"></a> NameFieldNumber

```csharp
public const int NameFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_Types_CVar_ValueFieldNumber"></a> ValueFieldNumber

```csharp
public const int ValueFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_Types_CVar_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_Types_CVar_HasName"></a> HasName

```csharp
public bool HasName { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_Types_CVar_HasValue"></a> HasValue

```csharp
public bool HasValue { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_Types_CVar_Name"></a> Name

```csharp
public string Name { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_Types_CVar_Parser"></a> Parser

```csharp
public static MessageParser<CMsg_CVars.Types.CVar> Parser { get; }
```

#### Property Value

 MessageParser<[CMsg\_CVars](Divine.Protobufs.Dota2.CMsg\_CVars.md).[Types](Divine.Protobufs.Dota2.CMsg\_CVars.Types.md).[CVar](Divine.Protobufs.Dota2.CMsg\_CVars.Types.CVar.md)\>

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_Types_CVar_Value"></a> Value

```csharp
public string Value { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_Types_CVar_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_Types_CVar_ClearName"></a> ClearName\(\)

```csharp
public void ClearName()
```

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_Types_CVar_ClearValue"></a> ClearValue\(\)

```csharp
public void ClearValue()
```

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_Types_CVar_Clone"></a> Clone\(\)

```csharp
public CMsg_CVars.Types.CVar Clone()
```

#### Returns

 [CMsg\_CVars](Divine.Protobufs.Dota2.CMsg\_CVars.md).[Types](Divine.Protobufs.Dota2.CMsg\_CVars.Types.md).[CVar](Divine.Protobufs.Dota2.CMsg\_CVars.Types.CVar.md)

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_Types_CVar_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_Types_CVar_Equals_Divine_Protobufs_Dota2_CMsg_CVars_Types_CVar_"></a> Equals\(CVar\)

```csharp
public bool Equals(CMsg_CVars.Types.CVar other)
```

#### Parameters

`other` [CMsg\_CVars](Divine.Protobufs.Dota2.CMsg\_CVars.md).[Types](Divine.Protobufs.Dota2.CMsg\_CVars.Types.md).[CVar](Divine.Protobufs.Dota2.CMsg\_CVars.Types.CVar.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_Types_CVar_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_Types_CVar_MergeFrom_Divine_Protobufs_Dota2_CMsg_CVars_Types_CVar_"></a> MergeFrom\(CVar\)

```csharp
public void MergeFrom(CMsg_CVars.Types.CVar other)
```

#### Parameters

`other` [CMsg\_CVars](Divine.Protobufs.Dota2.CMsg\_CVars.md).[Types](Divine.Protobufs.Dota2.CMsg\_CVars.Types.md).[CVar](Divine.Protobufs.Dota2.CMsg\_CVars.Types.CVar.md)

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_Types_CVar_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_Types_CVar_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsg_CVars_Types_CVar_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

