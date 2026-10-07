# <a id="Divine_Protobufs_Dota2_CMsgPlayerTitleData"></a> Class CMsgPlayerTitleData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgPlayerTitleData : IMessage<CMsgPlayerTitleData>, IEquatable<CMsgPlayerTitleData>, IDeepCloneable<CMsgPlayerTitleData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgPlayerTitleData](Divine.Protobufs.Dota2.CMsgPlayerTitleData.md)

#### Implements

IMessage<CMsgPlayerTitleData\>, 
[IEquatable<CMsgPlayerTitleData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgPlayerTitleData\>, 
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
[EnumerableExtensions.In<CMsgPlayerTitleData\>\(CMsgPlayerTitleData, params CMsgPlayerTitleData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgPlayerTitleData__ctor"></a> CMsgPlayerTitleData\(\)

```csharp
public CMsgPlayerTitleData()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerTitleData__ctor_Divine_Protobufs_Dota2_CMsgPlayerTitleData_"></a> CMsgPlayerTitleData\(CMsgPlayerTitleData\)

```csharp
public CMsgPlayerTitleData(CMsgPlayerTitleData other)
```

#### Parameters

`other` [CMsgPlayerTitleData](Divine.Protobufs.Dota2.CMsgPlayerTitleData.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgPlayerTitleData_ActiveFieldNumber"></a> ActiveFieldNumber

```csharp
public const int ActiveFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerTitleData_EventIdFieldNumber"></a> EventIdFieldNumber

```csharp
public const int EventIdFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerTitleData_TitleFieldNumber"></a> TitleFieldNumber

```csharp
public const int TitleFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgPlayerTitleData_Active"></a> Active

```csharp
public uint Active { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerTitleData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgPlayerTitleData_EventId"></a> EventId

```csharp
public RepeatedField<uint> EventId { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

### <a id="Divine_Protobufs_Dota2_CMsgPlayerTitleData_HasActive"></a> HasActive

```csharp
public bool HasActive { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerTitleData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgPlayerTitleData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgPlayerTitleData](Divine.Protobufs.Dota2.CMsgPlayerTitleData.md)\>

### <a id="Divine_Protobufs_Dota2_CMsgPlayerTitleData_Title"></a> Title

```csharp
public RepeatedField<uint> Title { get; }
```

#### Property Value

 RepeatedField<[uint](https://learn.microsoft.com/dotnet/api/system.uint32)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgPlayerTitleData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerTitleData_ClearActive"></a> ClearActive\(\)

```csharp
public void ClearActive()
```

### <a id="Divine_Protobufs_Dota2_CMsgPlayerTitleData_Clone"></a> Clone\(\)

```csharp
public CMsgPlayerTitleData Clone()
```

#### Returns

 [CMsgPlayerTitleData](Divine.Protobufs.Dota2.CMsgPlayerTitleData.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerTitleData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerTitleData_Equals_Divine_Protobufs_Dota2_CMsgPlayerTitleData_"></a> Equals\(CMsgPlayerTitleData\)

```csharp
public bool Equals(CMsgPlayerTitleData other)
```

#### Parameters

`other` [CMsgPlayerTitleData](Divine.Protobufs.Dota2.CMsgPlayerTitleData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerTitleData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerTitleData_MergeFrom_Divine_Protobufs_Dota2_CMsgPlayerTitleData_"></a> MergeFrom\(CMsgPlayerTitleData\)

```csharp
public void MergeFrom(CMsgPlayerTitleData other)
```

#### Parameters

`other` [CMsgPlayerTitleData](Divine.Protobufs.Dota2.CMsgPlayerTitleData.md)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerTitleData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgPlayerTitleData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgPlayerTitleData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

