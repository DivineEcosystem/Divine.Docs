# <a id="Divine_Protobufs_Dota2_CMsgLobbyPlaytestDetails"></a> Class CMsgLobbyPlaytestDetails

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgLobbyPlaytestDetails : IMessage<CMsgLobbyPlaytestDetails>, IEquatable<CMsgLobbyPlaytestDetails>, IDeepCloneable<CMsgLobbyPlaytestDetails>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgLobbyPlaytestDetails](Divine.Protobufs.Dota2.CMsgLobbyPlaytestDetails.md)

#### Implements

IMessage<CMsgLobbyPlaytestDetails\>, 
[IEquatable<CMsgLobbyPlaytestDetails\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgLobbyPlaytestDetails\>, 
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
[EnumerableExtensions.In<CMsgLobbyPlaytestDetails\>\(CMsgLobbyPlaytestDetails, params CMsgLobbyPlaytestDetails\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlaytestDetails__ctor"></a> CMsgLobbyPlaytestDetails\(\)

```csharp
public CMsgLobbyPlaytestDetails()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlaytestDetails__ctor_Divine_Protobufs_Dota2_CMsgLobbyPlaytestDetails_"></a> CMsgLobbyPlaytestDetails\(CMsgLobbyPlaytestDetails\)

```csharp
public CMsgLobbyPlaytestDetails(CMsgLobbyPlaytestDetails other)
```

#### Parameters

`other` [CMsgLobbyPlaytestDetails](Divine.Protobufs.Dota2.CMsgLobbyPlaytestDetails.md)

## Fields

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlaytestDetails_JsonFieldNumber"></a> JsonFieldNumber

```csharp
public const int JsonFieldNumber = 1
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlaytestDetails_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlaytestDetails_HasJson"></a> HasJson

```csharp
public bool HasJson { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlaytestDetails_Json"></a> Json

```csharp
public string Json { get; set; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlaytestDetails_Parser"></a> Parser

```csharp
public static MessageParser<CMsgLobbyPlaytestDetails> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgLobbyPlaytestDetails](Divine.Protobufs.Dota2.CMsgLobbyPlaytestDetails.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlaytestDetails_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlaytestDetails_ClearJson"></a> ClearJson\(\)

```csharp
public void ClearJson()
```

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlaytestDetails_Clone"></a> Clone\(\)

```csharp
public CMsgLobbyPlaytestDetails Clone()
```

#### Returns

 [CMsgLobbyPlaytestDetails](Divine.Protobufs.Dota2.CMsgLobbyPlaytestDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlaytestDetails_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlaytestDetails_Equals_Divine_Protobufs_Dota2_CMsgLobbyPlaytestDetails_"></a> Equals\(CMsgLobbyPlaytestDetails\)

```csharp
public bool Equals(CMsgLobbyPlaytestDetails other)
```

#### Parameters

`other` [CMsgLobbyPlaytestDetails](Divine.Protobufs.Dota2.CMsgLobbyPlaytestDetails.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlaytestDetails_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlaytestDetails_MergeFrom_Divine_Protobufs_Dota2_CMsgLobbyPlaytestDetails_"></a> MergeFrom\(CMsgLobbyPlaytestDetails\)

```csharp
public void MergeFrom(CMsgLobbyPlaytestDetails other)
```

#### Parameters

`other` [CMsgLobbyPlaytestDetails](Divine.Protobufs.Dota2.CMsgLobbyPlaytestDetails.md)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlaytestDetails_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlaytestDetails_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgLobbyPlaytestDetails_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

