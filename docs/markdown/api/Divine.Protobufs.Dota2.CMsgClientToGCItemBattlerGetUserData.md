# <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGetUserData"></a> Class CMsgClientToGCItemBattlerGetUserData

Namespace: [Divine.Protobufs.Dota2](Divine.Protobufs.Dota2.md)  
Assembly: Divine.Protobufs.dll  

```csharp
public sealed class CMsgClientToGCItemBattlerGetUserData : IMessage<CMsgClientToGCItemBattlerGetUserData>, IEquatable<CMsgClientToGCItemBattlerGetUserData>, IDeepCloneable<CMsgClientToGCItemBattlerGetUserData>, IBufferMessage, IMessage
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[CMsgClientToGCItemBattlerGetUserData](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerGetUserData.md)

#### Implements

IMessage<CMsgClientToGCItemBattlerGetUserData\>, 
[IEquatable<CMsgClientToGCItemBattlerGetUserData\>](https://learn.microsoft.com/dotnet/api/system.iequatable\-1), 
IDeepCloneable<CMsgClientToGCItemBattlerGetUserData\>, 
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
[EnumerableExtensions.In<CMsgClientToGCItemBattlerGetUserData\>\(CMsgClientToGCItemBattlerGetUserData, params CMsgClientToGCItemBattlerGetUserData\[\]\)](Divine.Extensions.EnumerableExtensions.md\#Divine\_Extensions\_EnumerableExtensions\_In\_\_1\_\_\_0\_\_\_0\_\_\_)

## Constructors

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGetUserData__ctor"></a> CMsgClientToGCItemBattlerGetUserData\(\)

```csharp
public CMsgClientToGCItemBattlerGetUserData()
```

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGetUserData__ctor_Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGetUserData_"></a> CMsgClientToGCItemBattlerGetUserData\(CMsgClientToGCItemBattlerGetUserData\)

```csharp
public CMsgClientToGCItemBattlerGetUserData(CMsgClientToGCItemBattlerGetUserData other)
```

#### Parameters

`other` [CMsgClientToGCItemBattlerGetUserData](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerGetUserData.md)

## Properties

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGetUserData_Descriptor"></a> Descriptor

```csharp
public static MessageDescriptor Descriptor { get; }
```

#### Property Value

 MessageDescriptor

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGetUserData_Parser"></a> Parser

```csharp
public static MessageParser<CMsgClientToGCItemBattlerGetUserData> Parser { get; }
```

#### Property Value

 MessageParser<[CMsgClientToGCItemBattlerGetUserData](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerGetUserData.md)\>

## Methods

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGetUserData_CalculateSize"></a> CalculateSize\(\)

```csharp
public int CalculateSize()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGetUserData_Clone"></a> Clone\(\)

```csharp
public CMsgClientToGCItemBattlerGetUserData Clone()
```

#### Returns

 [CMsgClientToGCItemBattlerGetUserData](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerGetUserData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGetUserData_Equals_System_Object_"></a> Equals\(object\)

```csharp
public override bool Equals(object other)
```

#### Parameters

`other` [object](https://learn.microsoft.com/dotnet/api/system.object)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGetUserData_Equals_Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGetUserData_"></a> Equals\(CMsgClientToGCItemBattlerGetUserData\)

```csharp
public bool Equals(CMsgClientToGCItemBattlerGetUserData other)
```

#### Parameters

`other` [CMsgClientToGCItemBattlerGetUserData](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerGetUserData.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGetUserData_GetHashCode"></a> GetHashCode\(\)

```csharp
public override int GetHashCode()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGetUserData_MergeFrom_Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGetUserData_"></a> MergeFrom\(CMsgClientToGCItemBattlerGetUserData\)

```csharp
public void MergeFrom(CMsgClientToGCItemBattlerGetUserData other)
```

#### Parameters

`other` [CMsgClientToGCItemBattlerGetUserData](Divine.Protobufs.Dota2.CMsgClientToGCItemBattlerGetUserData.md)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGetUserData_MergeFrom_Google_Protobuf_CodedInputStream_"></a> MergeFrom\(CodedInputStream\)

```csharp
public void MergeFrom(CodedInputStream input)
```

#### Parameters

`input` CodedInputStream

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGetUserData_ToString"></a> ToString\(\)

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="Divine_Protobufs_Dota2_CMsgClientToGCItemBattlerGetUserData_WriteTo_Google_Protobuf_CodedOutputStream_"></a> WriteTo\(CodedOutputStream\)

```csharp
public void WriteTo(CodedOutputStream output)
```

#### Parameters

`output` CodedOutputStream

