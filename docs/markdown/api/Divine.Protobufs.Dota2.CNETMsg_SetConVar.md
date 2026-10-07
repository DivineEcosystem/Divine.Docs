# <a id="Divine_Protobufs_Dota2_CNETMsg_SetConVar"></a> Class CNETMsg\_SetConVar

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CNETMsg_SetConVar : IMessage<CNETMsg_SetConVar>, IEquatable<CNETMsg_SetConVar>, IDeepCloneable<CNETMsg_SetConVar>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CNETMsg\_SetConVar](Divine.Protobufs.Dota2.CNETMsg\_SetConVar.md)

#### Implements

IMessage<CNETMsg\_SetConVar\>, 
[IEquatable<CNETMsg\_SetConVar\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CNETMsg\_SetConVar\>, 
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
[EnumerableExtensions.In<CNETMsg\_SetConVar\>\(CNETMsg\_SetConVar, params CNETMsg\_SetConVar\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CNETMsg_SetConVar__ctor"></a> CNETMsg\_SetConVar\(\)

```csharp
public CNETMsg_SetConVar()
```

### <a id="Divine_Protobufs_Dota2_CNETMsg_SetConVar__ctor_Divine_Protobufs_Dota2_CNETMsg_SetConVar_"></a> CNETMsg\_SetConVar\(CNETMsg\_SetConVar\)

```csharp
public CNETMsg_SetConVar(CNETMsg_SetConVar other)
```

#### Parameters

`other` [CNETMsg\_SetConVar](Divine.Protobufs.Dota2.CNETMsg\_SetConVar.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CNETMsg_SetConVar_ConvarsFieldNumber"></a> ConvarsFieldNumber

```csharp
public const int ConvarsFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CNETMsg_SetConVar_Convars"></a> Convars

```csharp
public CMsg_CVars Convars { get; set; }
```

#### Property Value

 [CMsg\_CVars](Divine.Protobufs.Dota2.CMsg\_CVars.md)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SetConVar_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CNETMsg_SetConVar_Parser"></a> Parser

```csharp
public static MessageParser<CNETMsg_SetConVar> Parser { get; }
```

#### Property Value

 MessageParser<[CNETMsg\_SetConVar](Divine.Protobufs.Dota2.CNETMsg\_SetConVar.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CNETMsg_SetConVar_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SetConVar_Clone"></a> Clone\(\)

```csharp
public CNETMsg_SetConVar Clone()
```

#### Returns

 [CNETMsg\_SetConVar](Divine.Protobufs.Dota2.CNETMsg\_SetConVar.md)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SetConVar_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SetConVar_Equals_Divine_Protobufs_Dota2_CNETMsg_SetConVar_"></a> Equals\(CNETMsg\_SetConVar\)

```csharp
public bool Equals(CNETMsg_SetConVar other)
```

#### Parameters

`other` [CNETMsg\_SetConVar](Divine.Protobufs.Dota2.CNETMsg\_SetConVar.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SetConVar_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SetConVar_MergeFrom_Divine_Protobufs_Dota2_CNETMsg_SetConVar_"></a> MergeFrom\(CNETMsg\_SetConVar\)

```csharp
public void MergeFrom(CNETMsg_SetConVar other)
```

#### Parameters

`other` [CNETMsg\_SetConVar](Divine.Protobufs.Dota2.CNETMsg\_SetConVar.md)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SetConVar_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CNETMsg_SetConVar_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CNETMsg_SetConVar_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

