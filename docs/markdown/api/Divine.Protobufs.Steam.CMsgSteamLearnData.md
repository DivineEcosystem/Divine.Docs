# <a id="Divine_Protobufs_Steam_CMsgSteamLearnData"></a> Class CMsgSteamLearnData

Namespace: [Divine.Protobufs.Steam](Divine.Protobufs.Steam.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgSteamLearnData : IMessage<CMsgSteamLearnData>, IEquatable<CMsgSteamLearnData>, IDeepCloneable<CMsgSteamLearnData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgSteamLearnData](Divine.Protobufs.Steam.CMsgSteamLearnData.md)

#### Implements

IMessage<CMsgSteamLearnData\>, 
[IEquatable<CMsgSteamLearnData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgSteamLearnData\>, 
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
[EnumerableExtensions.In<CMsgSteamLearnData\>\(CMsgSteamLearnData, params CMsgSteamLearnData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnData__ctor"></a> CMsgSteamLearnData\(\)

```csharp
public CMsgSteamLearnData()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnData__ctor_Divine_Protobufs_Steam_CMsgSteamLearnData_"></a> CMsgSteamLearnData\(CMsgSteamLearnData\)

```csharp
public CMsgSteamLearnData(CMsgSteamLearnData other)
```

#### Parameters

`other` [CMsgSteamLearnData](Divine.Protobufs.Steam.CMsgSteamLearnData.md)

## Fields

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnData_DataObjectFieldNumber"></a> DataObjectFieldNumber

```csharp
public const int DataObjectFieldNumber = 3
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnData_DataSourceIdFieldNumber"></a> DataSourceIdFieldNumber

```csharp
public const int DataSourceIdFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnData_KeysFieldNumber"></a> KeysFieldNumber

```csharp
public const int KeysFieldNumber = 2
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnData_DataObject"></a> DataObject

```csharp
public CMsgSteamLearnDataObject DataObject { get; set; }
```

#### Property Value

 [CMsgSteamLearnDataObject](Divine.Protobufs.Steam.CMsgSteamLearnDataObject.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnData_DataSourceId"></a> DataSourceId

```csharp
public uint DataSourceId { get; set; }
```

#### Property Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnData_HasDataSourceId"></a> HasDataSourceId

```csharp
public bool HasDataSourceId { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnData_Keys"></a> Keys

```csharp
public RepeatedField<ulong> Keys { get; }
```

#### Property Value

 RepeatedField<[ulong](https://learn.microsoft.com/dotnet/api/system.uint64)\>

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgSteamLearnData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgSteamLearnData](Divine.Protobufs.Steam.CMsgSteamLearnData.md)\>

## Methods

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnData_ClearDataSourceId"></a> ClearDataSourceId\(\)

```csharp
public void ClearDataSourceId()
```

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnData_Clone"></a> Clone\(\)

```csharp
public CMsgSteamLearnData Clone()
```

#### Returns

 [CMsgSteamLearnData](Divine.Protobufs.Steam.CMsgSteamLearnData.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnData_Equals_Divine_Protobufs_Steam_CMsgSteamLearnData_"></a> Equals\(CMsgSteamLearnData\)

```csharp
public bool Equals(CMsgSteamLearnData other)
```

#### Parameters

`other` [CMsgSteamLearnData](Divine.Protobufs.Steam.CMsgSteamLearnData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnData_MergeFrom_Divine_Protobufs_Steam_CMsgSteamLearnData_"></a> MergeFrom\(CMsgSteamLearnData\)

```csharp
public void MergeFrom(CMsgSteamLearnData other)
```

#### Parameters

`other` [CMsgSteamLearnData](Divine.Protobufs.Steam.CMsgSteamLearnData.md)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Steam_CMsgSteamLearnData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

